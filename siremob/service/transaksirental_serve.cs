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
    internal class transaksirental_serve
    {
        private Koneksi koneksiDb = new Koneksi();

        // GENERATE NEXT ID FOR RENTAL
        public string GetNextIdRental()
        {
            try
            {
                string query = "SELECT id_rental FROM rental ORDER BY id_rental DESC LIMIT 1";
                DataTable dt = koneksiDb.EksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string maxId = dt.Rows[0][0].ToString();
                    if (maxId.StartsWith("R") && maxId.Length > 1)
                    {
                        string num = maxId.Substring(1);
                        if (int.TryParse(num, out int val))
                        {
                            val++;
                            return "R" + val.ToString("D2");
                        }
                    }
                }
            }
            catch { }
            return "R01";
        }

        // 1. MENGAMBIL DATA PELANGGAN UNTUK COMBOBOX
        public DataTable AmbilSemuaPelanggan()
        {
            // Database schema has column 'nama' not 'nama_pelanggan'
            string query = "SELECT id_pelanggan, nama AS nama_pelanggan FROM pelanggan";
            return koneksiDb.EksekusiQuery(query);
        }

        // 2. MENGAMBIL DATA MOBIL YANG TERSEDIA UNTUK COMBOBOX
        public DataTable AmMobilTersedia()
        {
            // Changed status to statusmobil and harga_sewa to hargasewaperhari based on schema
            string query = "SELECT id_mobil, merk, hargasewaperhari AS harga_sewa FROM mobil WHERE statusmobil = 'Tersedia'";
            return koneksiDb.EksekusiQuery(query);
        }

        // Fallback for UI if it calls AmbilMobilTersedia
        public DataTable AmbilMobilTersedia()
        {
            return AmMobilTersedia();
        }

        // 3. MENGAMBIL DATA UNTUK DATAGRIDVIEW (QUERY JOIN)
        public DataTable TampilkanDaftarRental()
        {
            string query = @"SELECT r.id_rental, p.nama AS nama_pelanggan, m.merk AS Mobil, 
                                    r.tanggalsewa, r.tanggalkembali_rencana, 
                                    r.totalbiaya_estimasi, r.statusrental 
                             FROM rental r
                             INNER JOIN pelanggan p ON r.id_pelanggan = p.id_pelanggan
                             INNER JOIN mobil m ON r.id_mobil = m.id_mobil";

            return koneksiDb.EksekusiQuery(query);
        }

        // 4. MENYIMPAN TRANSAKSI BARU & UPDATE STATUS MOBIL
        public bool SimpanTransaksiSewa(string idRental, string idMobil, string idPelanggan, DateTime tglSewa, DateTime tglKembali, decimal totalBiaya, string jaminan = "KTP")
        {
            string sSewa = tglSewa.ToString("yyyy-MM-dd HH:mm:ss");
            string sKembali = tglKembali.ToString("yyyy-MM-dd HH:mm:ss");
            string idPetugas = Session.IdPetugas ?? "003"; // fallback to kasir

            string queryInsert = $@"INSERT INTO rental (id_rental, id_mobil, id_pelanggan, id_petugas, tanggalsewa, tanggalkembali_rencana, jaminan, totalbiaya_estimasi, statusrental) 
                                   VALUES ('{idRental}', '{idMobil}', '{idPelanggan}', '{idPetugas}', '{sSewa}', '{sKembali}', '{jaminan}', {totalBiaya}, 'Berjalan')";

            int rowsInserted = koneksiDb.EksekusiNonQuery(queryInsert);
            if (rowsInserted > 0)
            {
                // Automatically change car status to 'Disewa'
                string queryUpdateMobil = $"UPDATE mobil SET statusmobil = 'Disewa' WHERE id_mobil = '{idMobil}'";
                koneksiDb.EksekusiNonQuery(queryUpdateMobil);
                return true;
            }
            return false;
        }

        public bool SimpanTransaksiSewaDenganModel(transaksirental objekSewa)
        {
            return SimpanTransaksiSewa(objekSewa.IdRental, objekSewa.IdMobil, objekSewa.IdPelanggan, objekSewa.TanggalSewa, objekSewa.TanggalKembaliRencana, objekSewa.TotalBiayaEstimasi, objekSewa.Jaminan);
        }
    }
}