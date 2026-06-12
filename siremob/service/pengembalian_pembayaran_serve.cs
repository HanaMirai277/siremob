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
    internal class pengembalian_pembayaran_serve
    {
        private Koneksi koneksiDb = new Koneksi();
        private string query;

        // Fungsi otomatis untuk ID Pengembalian (Format: 001, 002, dst)
        public string BuatIdOtomatis()
        {
            string idBaru = "001";
            query = "SELECT id_pengembalian FROM pengembalian ORDER BY id_pengembalian DESC LIMIT 1";

            DataTable dt = koneksiDb.EksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                int angkaTerakhir = Convert.ToInt32(dt.Rows[0]["id_pengembalian"]);
                int angkaBaru = angkaTerakhir + 1;
                idBaru = angkaBaru.ToString("D3");
            }

            return idBaru;
        }

        // Fungsi ambil detail rental menggunakan JOIN untuk menarik data lintas tabel (pelanggan, rental, mobil)
        public DataTable AmbilDetailRental(string idRental)
        {
            string query = $@"SELECT 
                r.id_mobil,
                p.nama AS nama_pelanggan,
                m.platnomor,
                m.merk,
                m.tipe,
                m.hargasewaperhari,
                r.jaminan,
                r.totalbiaya_estimasi,
                r.tanggalkembali_rencana
              FROM rental r
              INNER JOIN pelanggan p ON r.id_pelanggan = p.id_pelanggan
              INNER JOIN mobil m ON r.id_mobil = m.id_mobil
              WHERE r.id_rental = '{idRental}' AND r.statusrental = 'Berjalan';";

            return koneksiDb.EksekusiQuery(query);
        }

        // Fungsi simpan dan update status
        public bool SimpanTransaksiPengembalian(pengembalian_pembayaran_model pm, string idMobil)
        {
            string tglFormat = pm.TglKembaliAktual.ToString("yyyy-MM-dd");

            // Insert ke tabel pengembalian
            string queryInsert = $@"INSERT INTO pengembalian VALUES (
                                    '{pm.IdPengembalian}', 
                                    '{pm.IdRental}', 
                                    '{tglFormat}', 
                                    '{pm.KondisiMobil}', 
                                    {pm.KeterlambatanHari}, 
                                    {pm.DendaKeterlambatan}, 
                                    {pm.DendaKerusakan}, 
                                    {pm.TotalBayar}, 
                                    '{pm.StatusPembayaran}')";

            // Update status rental menjadi 'Selesai'
            string queryUpdateRental = $"UPDATE rental SET statusrental = 'Selesai' WHERE id_rental = '{pm.IdRental}'";

            // Update status mobil menjadi 'Tersedia'
            string queryUpdateMobil = $"UPDATE mobil SET statusmobil = 'Tersedia' WHERE id_mobil = '{idMobil}'";

            // Eksekusi ketiga query tersebut
            int hasilInsert = koneksiDb.EksekusiNonQuery(queryInsert);
            int hasilRental = koneksiDb.EksekusiNonQuery(queryUpdateRental);
            int hasilMobil = koneksiDb.EksekusiNonQuery(queryUpdateMobil);

            // Jika ketiganya berhasil, return true
            return (hasilInsert > 0 && hasilRental > 0 && hasilMobil > 0);
        }

        // Fungsi untuk menampilkan data ke Data Grid View 
        public DataTable TampilkanSemuaPengembalian()
        {
            query = @"SELECT 
                        pg.id_pengembalian AS `ID Pengembalian`,
                        pg.id_rental AS `ID Rental`,
                        p.nama AS `Nama Pelanggan`,
                        m.platnomor AS `Plat Nomor`,
                        m.merk AS `Merk Mobil`,
                        m.tipe AS `Tipe Mobil`,
                        pg.tanggalkembali_aktual AS `Tanggal Kembali Aktual`
                      FROM pengembalian pg
                      INNER JOIN rental r ON pg.id_rental = r.id_rental
                      INNER JOIN pelanggan p ON r.id_pelanggan = p.id_pelanggan
                      INNER JOIN mobil m ON r.id_mobil = m.id_mobil";
            return koneksiDb.EksekusiQuery(query);
        }

        // Fungsi mengambil daftar ID Rental yang statusnya masih berjalan
        public List<string> AmbilSemuaIdRentalBerjalan()
        {
            List<string> daftarId = new List<string>();
            string queryId = "SELECT id_rental FROM rental WHERE statusrental = 'Berjalan' ORDER BY id_rental ASC;";

            DataTable dt = koneksiDb.EksekusiQuery(queryId);
            foreach (DataRow row in dt.Rows)
            {
                daftarId.Add(row["id_rental"].ToString());
            }
            return daftarId;
        }
    }
}
