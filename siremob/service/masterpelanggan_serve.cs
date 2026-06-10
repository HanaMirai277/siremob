using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using siremob.model;
using siremob.konfigurasi;

namespace siremob.service
{
    internal class masterpelanggan_serve
    {
        private Koneksi _koneksi;

        public masterpelanggan_serve()
        {
            _koneksi = new Koneksi();
            BuatTabelJikaTidakAda();
        }

        private void BuatTabelJikaTidakAda()
        {
            try
            {
                // Cek apakah tabel pelanggan sudah ada
                string checkQuery = "SHOW TABLES LIKE 'pelanggan'";
                DataTable dt = _koneksi.EksekusiQuery(checkQuery);
                if (dt == null || dt.Rows.Count == 0)
                {
                    string createQuery = @"
                        CREATE TABLE pelanggan (
                            id_pelanggan VARCHAR(20) PRIMARY KEY,
                            nik VARCHAR(20) NOT NULL,
                            nama VARCHAR(100) NOT NULL,
                            no_hp VARCHAR(20) NOT NULL,
                            alamat TEXT NOT NULL,
                            no_sim VARCHAR(30) NOT NULL
                        )";
                    _koneksi.EksekusiNonQuery(createQuery);
                }
                else
                {
                    // Jika tabel sudah ada, pastikan kolom 'alamat' dan 'no_sim' lengkap
                    EnsureColumnExists("alamat", "TEXT NOT NULL");
                    EnsureColumnExists("no_sim", "VARCHAR(30) NOT NULL");
                }

                // Isi data contoh (seeding) setelah memastikan tabel ada
                SeedSampleData();
            }
            catch (Exception)
            {
                // Abaikan jika database tidak aktif atau error lainnya saat inisialisasi
            }
        }

        private void EnsureColumnExists(string columnName, string columnDefinition)
        {
            try
            {
                string checkColQuery = "SHOW COLUMNS FROM pelanggan LIKE '" + columnName + "'";
                DataTable dtCol = _koneksi.EksekusiQuery(checkColQuery);
                if (dtCol == null || dtCol.Rows.Count == 0)
                {
                    string alterQuery = "ALTER TABLE pelanggan ADD COLUMN " + columnName + " " + columnDefinition;
                    _koneksi.EksekusiNonQuery(alterQuery);
                }
            }
            catch { /* Abaikan error pemeriksaan kolom */ }
        }

        private void SeedSampleData()
        {
            try
            {
                // 1. Seed Pelanggan jika kosong
                string countPelangganQuery = "SELECT COUNT(*) FROM pelanggan";
                DataTable dtPlg = _koneksi.EksekusiQuery(countPelangganQuery);
                if (dtPlg != null && int.Parse(dtPlg.Rows[0][0].ToString()) == 0)
                {
                    string insertPlg = @"
                        INSERT INTO pelanggan (id_pelanggan, nik, nama, no_hp, alamat, no_sim) VALUES 
                        ('PLG001', '1234567890123456', 'Ahmad Dani', '081234567890', 'Jl. Malioboro No. 12, Yogyakarta', '123456789012'),
                        ('PLG002', '9876543210987654', 'Siti Aminah', '089876543210', 'Jl. Dago No. 45, Bandung', '987654321098'),
                        ('PLG003', '5555555555555555', 'Budi Santoso', '085555555555', 'Jl. Sudirman No. 99, Jakarta', '555555555555')";
                    _koneksi.EksekusiNonQuery(insertPlg);
                }

                // 2. Seed Mobil jika ada dan kosong
                string checkMobilTable = "SHOW TABLES LIKE 'Mobil'";
                DataTable dtMobilTable = _koneksi.EksekusiQuery(checkMobilTable);
                if (dtMobilTable != null && dtMobilTable.Rows.Count > 0)
                {
                    string countMobilQuery = "SELECT COUNT(*) FROM Mobil";
                    DataTable dtMob = _koneksi.EksekusiQuery(countMobilQuery);
                    if (dtMob != null && int.Parse(dtMob.Rows[0][0].ToString()) == 0)
                    {
                        string insertMob = @"
                            INSERT INTO Mobil (id_mobil, platnomor, merk, tipe, tahun, warna, hargasewaperhari, statusmobil, foto) VALUES 
                            ('001', 'AB 1234 CD', 'Toyota', 'Avanza', 2023, 'Silver', 350000, 'Tersedia', ''),
                            ('002', 'AB 5678 EF', 'Honda', 'Civic', 2022, 'Black', 450000, 'Tersedia', ''),
                            ('003', 'AB 9012 GH', 'Daihatsu', 'Xenia', 2021, 'White', 300000, 'Tersedia', '')";
                        _koneksi.EksekusiNonQuery(insertMob);
                    }
                }
            }
            catch { /* Abaikan jika terjadi kesalahan seeding */ }
        }

        public string GetNextIdPelanggan()
        {
            try
            {
                string query = "SELECT id_pelanggan FROM pelanggan ORDER BY id_pelanggan DESC LIMIT 1";
                DataTable dt = _koneksi.EksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string maxId = dt.Rows[0][0].ToString();
                    if (maxId.StartsWith("PLG") && maxId.Length > 3)
                    {
                        string numberPart = maxId.Substring(3);
                        if (int.TryParse(numberPart, out int nextVal))
                        {
                            nextVal++;
                            return "PLG" + nextVal.ToString("D3");
                        }
                    }
                }
            }
            catch
            {
                // Abaikan error koneksi saat penentuan ID otomatis
            }
            return "PLG001";
        }

        public DataTable TampilData()
        {
            string query = "SELECT id_pelanggan, nik, nama, no_hp, alamat, no_sim FROM pelanggan";
            return _koneksi.EksekusiQuery(query);
        }

        public DataTable CariData(string cari)
        {
            string escapedCari = cari.Replace("'", "''");
            string query = "SELECT id_pelanggan, nik, nama, no_hp, alamat, no_sim FROM pelanggan WHERE id_pelanggan LIKE '%" + escapedCari + "%' OR nik LIKE '%" + escapedCari + "%' OR nama LIKE '%" + escapedCari + "%'";
            return _koneksi.EksekusiQuery(query);
        }

        public void TambahData(masterpelanggan mp)
        {
            string query = "INSERT INTO pelanggan (id_pelanggan, nik, nama, no_hp, alamat, no_sim) VALUES ('" +
                mp.id_pelanggan.Replace("'", "''") + "', '" +
                mp.nik.Replace("'", "''") + "', '" +
                mp.nama.Replace("'", "''") + "', '" +
                mp.no_hp.Replace("'", "''") + "', '" +
                mp.alamat.Replace("'", "''") + "', '" +
                mp.no_sim.Replace("'", "''") + "')";
            _koneksi.EksekusiNonQuery(query);
        }

        public void UbahData(masterpelanggan mp)
        {
            string query = "UPDATE pelanggan SET nik = '" + mp.nik.Replace("'", "''") +
                "', nama = '" + mp.nama.Replace("'", "''") +
                "', no_hp = '" + mp.no_hp.Replace("'", "''") +
                "', alamat = '" + mp.alamat.Replace("'", "''") +
                "', no_sim = '" + mp.no_sim.Replace("'", "''") +
                "' WHERE id_pelanggan = '" + mp.id_pelanggan.Replace("'", "''") + "'";
            _koneksi.EksekusiNonQuery(query);
        }

        public void HapusData(string id_pelanggan)
        {
            string query = "DELETE FROM pelanggan WHERE id_pelanggan = '" + id_pelanggan.Replace("'", "''") + "'";
            _koneksi.EksekusiNonQuery(query);
        }

        public bool CekIdPelanggan(string id_pelanggan)
        {
            string query = "SELECT COUNT(*) FROM pelanggan WHERE id_pelanggan = '" + id_pelanggan.Replace("'", "''") + "'";
            DataTable dt = _koneksi.EksekusiQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0][0].ToString()) > 0;
            }
            return false;
        }

        public bool CekNik(string nik)
        {
            string query = "SELECT COUNT(*) FROM pelanggan WHERE nik = '" + nik.Replace("'", "''") + "'";
            DataTable dt = _koneksi.EksekusiQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0][0].ToString()) > 0;
            }
            return false;
        }
    }
}
