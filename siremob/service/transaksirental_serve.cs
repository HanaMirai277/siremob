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
        // Instansiasi objek kelas Koneksi Anda
        private Koneksi koneksiDb = new Koneksi();

        // 1. MENGAMBIL DATA PELANGGAN UNTUK COMBOBOX
        public DataTable AmbilSemuaPelanggan()
        {
            string query = "SELECT id_pelanggan, nama_pelanggan FROM pelanggan";
            return koneksiDb.EksekusiQuery(query);
        }

        // 2. MENGAMBIL DATA MOBIL YANG TERSEDIA UNTUK COMBOBOX
        public DataTable AmbilMobilTersedia()
        {
            // Menarik id, merk, dan harga sewa untuk keperluan kalkulasi di Form
            string query = "SELECT id_mobil, merk, harga_sewa FROM mobil WHERE status = 'Tersedia'";
            return koneksiDb.EksekusiQuery(query);
        }

        // 3. MENGAMBIL DATA UNTUK DATAGRIDVIEW (QUERY JOIN)
        public DataTable TampilkanDaftarRental()
        {
            // Sesuaikan nama 'id_rental_tabel' dengan nama asli tabel sewa Anda di database
            string query = @"SELECT r.id_rental, p.nama_pelanggan, m.merk AS Mobil, 
                                    r.tanggalsewa, r.tangkalkembali_rencana, 
                                    r.totalbiaya_estimasi, r.statusrental 
                             FROM id_rental_tabel r
                             INNER JOIN pelanggan p ON r.id_pelanggan = p.id_pelanggan
                             INNER JOIN mobil m ON r.id_mobil = m.id_mobil";

            return koneksiDb.EksekusiQuery(query);
        }

        // 4. MENYIMPAN TRANSAKSI BARU & UPDATE STATUS MOBIL
        // Menggunakan objek model 'transaksirental' sebagai parameter tunggal
        public bool SimpanTransaksiSewaDenganModel(transaksirental objekSewa)
        {
            string sSewa = objekSewa.TanggalSewa.ToString("yyyy-MM-dd");
            string sKembali = objekSewa.TanggalKembaliRencana.ToString("yyyy-MM-dd");

            string queryInsert = $@"INSERT INTO id_rental_tabel 
                           VALUES ('{objekSewa.IdRental}', '{objekSewa.IdMobil}', '{objekSewa.IdPelanggan}', 
                                   '{sSewa}', '{sKembali}', '{objekSewa.Jaminan}', {objekSewa.TotalBiayaEstimasi}, '{objekSewa.StatusRental}')";

            return koneksiDb.EksekusiNonQuery(queryInsert) > 0;
        }
    }
}