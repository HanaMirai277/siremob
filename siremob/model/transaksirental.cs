using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siremob.model
{
    internal class transaksirental
    {
        // Menyimpan properti fields sesuai kolom di tabel database sewa Anda
        public string IdRental { get; set; }
        public string IdMobil { get; set; }
        public string IdPelanggan { get; set; }
        public DateTime TanggalSewa { get; set; }
        public DateTime TanggalKembaliRencana { get; set; }
        public string Jaminan { get; set; }
        public decimal TotalBiayaEstimasi { get; set; } // Sudah tepat menggunakan decimal
        public string StatusRental { get; set; }

        // Properti Tambahan untuk keperluan cetak nota / transfer data antar Form (Opsional)
        public string NamaPelanggan { get; set; }
        public string MerkMobil { get; set; }

        // Constructor Kosong
        public transaksirental()
        {
        }

        // Constructor Lengkap (Disesuaikan parameter totalBiayaEstimasi menjadi decimal)
        public transaksirental(string idRental, string idMobil, string idPelanggan, DateTime tanggalSewa, DateTime tanggalKembaliRencana, string jaminan, decimal totalBiayaEstimasi, string statusRental)
        {
            IdRental = idRental;
            IdMobil = idMobil;
            IdPelanggan = idPelanggan;
            TanggalSewa = tanggalSewa;
            TanggalKembaliRencana = tanggalKembaliRencana;
            Jaminan = jaminan;
            TotalBiayaEstimasi = totalBiayaEstimasi; // Nilai decimal ditampung ke properti decimal
            StatusRental = statusRental;
        }
    }
}