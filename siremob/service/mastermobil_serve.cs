using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using siremob.model;
using siremob.konfigurasi;

namespace siremob.service
{
    internal class mastermobil_serve
    {
        private Koneksi _koneksi;

        public mastermobil_serve()
        {
            _koneksi = new Koneksi();
        }

        // ============================================================
        // AMBIL KODE OTOMATIS — format M001, M002, M003 dst
        // Cari semua ID yang ada, ambil nomor terkecil yang belum dipakai
        // ============================================================
        public string AmbilKodeOtomatis()
        {
            string query = "SELECT id_mobil FROM Mobil ORDER BY id_mobil ASC";
            try
            {
                DataTable dt = _koneksi.EksekusiQuery(query);

                // Kumpulkan semua nomor yang sudah ada
                List<int> nomorAda = new List<int>();
                foreach (DataRow row in dt.Rows)
                {
                    string id = row[0].ToString(); // "M001", "M002" dst
                    if (id.Length >= 2 && id.StartsWith("M"))
                    {
                        int nomor;
                        if (int.TryParse(id.Substring(1), out nomor))
                            nomorAda.Add(nomor);
                    }
                }

                // Cari nomor urut berikutnya (isi celah kalau ada yang dihapus)
                int berikutnya = 1;
                while (nomorAda.Contains(berikutnya))
                    berikutnya++;

                return "M" + berikutnya.ToString("d3");
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuat kode otomatis di layer service: " + ex.Message);
            }
        }

        // ============================================================
        // URUT ULANG ID setelah hapus — M001 M002 M003 tanpa celah
        // ============================================================
        public void UrutUlangId()
        {
            string queryAmbil = "SELECT id_mobil FROM Mobil ORDER BY id_mobil ASC";
            try
            {
                DataTable dt = _koneksi.EksekusiQuery(queryAmbil);

                int urut = 1;
                foreach (DataRow row in dt.Rows)
                {
                    string idLama = row[0].ToString();
                    string idBaru = "M" + urut.ToString("d3");

                    if (idLama != idBaru)
                    {
                        // Ganti nama file foto juga kalau ada
                        string folderAssets = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
                        string[] ekstensi = { ".jpg", ".jpeg", ".png", ".bmp" };
                        foreach (string ext in ekstensi)
                        {
                            string fotoLama = Path.Combine(folderAssets, idLama + ext);
                            string fotoBaru = Path.Combine(folderAssets, idBaru + ext);
                            if (File.Exists(fotoLama) && !File.Exists(fotoBaru))
                                File.Move(fotoLama, fotoBaru);
                        }

                        // Update ID dan path foto di database
                        string queryUpdate = "UPDATE Mobil SET id_mobil = '" + idBaru + "', " +
                                             "foto = '" + idBaru + "' " +
                                             "WHERE id_mobil = '" + idLama + "'";
                        _koneksi.EksekusiNonQuery(queryUpdate);
                    }
                    urut++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengurutkan ulang ID: " + ex.Message);
            }
        }

        // ============================================================
        // TAMPIL DATA
        // ============================================================
        public DataTable TampilData()
        {
            string query = "SELECT * FROM Mobil ORDER BY id_mobil ASC";
            return _koneksi.EksekusiQuery(query);
        }

        // ============================================================
        // CARI DATA
        // ============================================================
        public DataTable CariData(string cari)
        {
            string query = "SELECT * FROM Mobil WHERE id_mobil LIKE '%" + cari + "%' " +
                           "OR platnomor LIKE '%" + cari + "%' " +
                           "OR merk LIKE '%" + cari + "%'";
            return _koneksi.EksekusiQuery(query);
        }

        // ============================================================
        // TAMBAH DATA — foto disimpan sebagai nama ID saja (misal "M001")
        // ============================================================
        public void TambahData(mastermobil mm)
        {
            // Simpan hanya nama ID di kolom foto (tanpa ekstensi, dicari otomatis nanti)
            string query = "INSERT INTO Mobil (id_mobil, platnomor, merk, tipe, tahun, warna, hargasewaperhari, statusmobil, foto) " +
                           "VALUES ('" + mm.id_mobil + "', '" + mm.platnomor + "', '" + mm.merk + "', '" + mm.tipe + "', " + mm.tahun + ", " +
                           "'" + mm.warna + "', " + mm.hargasewaperhari.ToString().Replace(",", ".") + ", '" + mm.statusmobil + "', '" + mm.id_mobil + "')";
            _koneksi.EksekusiNonQuery(query);
        }

        // ============================================================
        // UBAH DATA
        // ============================================================
        public void UbahData(mastermobil mm)
        {
            string query = "UPDATE Mobil SET platnomor = '" + mm.platnomor + "', merk = '" + mm.merk + "', tipe = '" + mm.tipe + "', " +
                           "tahun = " + mm.tahun + ", warna = '" + mm.warna + "', " +
                           "hargasewaperhari = " + mm.hargasewaperhari.ToString().Replace(",", ".") + ", " +
                           "statusmobil = '" + mm.statusmobil + "' " +
                           "WHERE id_mobil = '" + mm.id_mobil + "'";
            _koneksi.EksekusiNonQuery(query);
        }

        // ============================================================
        // HAPUS DATA — lalu urut ulang ID otomatis
        // ============================================================
        public void HapusData(string id_mobil)
        {
            // Hapus file foto dari assets kalau ada
            string folderAssets = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
            string[] ekstensi = { ".jpg", ".jpeg", ".png", ".bmp" };
            foreach (string ext in ekstensi)
            {
                string fotoPath = Path.Combine(folderAssets, id_mobil + ext);
                if (File.Exists(fotoPath))
                    File.Delete(fotoPath);
            }

            string query = "DELETE FROM Mobil WHERE id_mobil = '" + id_mobil + "'";
            _koneksi.EksekusiNonQuery(query);

            // Urut ulang ID setelah hapus
            UrutUlangId();
        }

        // ============================================================
        // CEK DUPLIKAT
        // ============================================================
        public bool CekIdMobil(string id_mobil)
        {
            string query = "SELECT COUNT(*) FROM Mobil WHERE id_mobil = '" + id_mobil + "'";
            DataTable dt = _koneksi.EksekusiQuery(query);
            return int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        public bool CekPlatNomor(string platnomor)
        {
            string query = "SELECT COUNT(*) FROM Mobil WHERE platnomor = '" + platnomor + "'";
            DataTable dt = _koneksi.EksekusiQuery(query);
            return int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        // ============================================================
        // CARI FILE FOTO dari folder assets berdasarkan ID mobil
        // Coba semua ekstensi: .jpg .jpeg .png .bmp
        // ============================================================
        public string CariPathFoto(string idMobil)
        {
            string folderAssets = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
            string[] ekstensi = { ".jpg", ".jpeg", ".png", ".bmp" };
            foreach (string ext in ekstensi)
            {
                string fullPath = Path.Combine(folderAssets, idMobil + ext);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return ""; // tidak ditemukan
        }

        // ============================================================
        // SIMPAN FOTO ke folder assets dengan nama = ID mobil
        // Dipanggil saat user Browse foto
        // ============================================================
        public string SimpanFotoKeAssets(string pathAsli, string idMobil)
        {
            string folderAssets = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");

            // Buat folder assets kalau belum ada
            if (!Directory.Exists(folderAssets))
                Directory.CreateDirectory(folderAssets);

            string ekstensi = Path.GetExtension(pathAsli).ToLower(); // misal ".jpg"
            string namaFileBaru = idMobil + ekstensi;                // misal "M001.jpg"
            string pathTujuan = Path.Combine(folderAssets, namaFileBaru);

            // Hapus foto lama dengan nama ID yang sama (semua ekstensi)
            string[] semuaEkstensi = { ".jpg", ".jpeg", ".png", ".bmp" };
            foreach (string ext in semuaEkstensi)
            {
                string fotoLama = Path.Combine(folderAssets, idMobil + ext);
                if (File.Exists(fotoLama))
                    File.Delete(fotoLama);
            }

            File.Copy(pathAsli, pathTujuan, true);
            return pathTujuan;
        }
    }
}