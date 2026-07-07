using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siremob.model
{
    internal class transaksirental
    {
        public string IdRental { get; set; }
        public string IdMobil { get; set; }
        public string IdPelanggan { get; set; }
        public DateTime TanggalSewa { get; set; }
        public DateTime TanggalKembaliRencana { get; set; }
        public string Jaminan { get; set; }
        public decimal TotalBiayaEstimasi { get; set; }
        public string StatusRental { get; set; }

        public string NamaPelanggan { get; set; }
        public string MerkMobil { get; set; }

        // Constructor Kosong
        public transaksirental()
        {
        }

        public transaksirental(string idRental, string idMobil, string idPelanggan, DateTime tanggalSewa, DateTime tanggalKembaliRencana, string jaminan, decimal totalBiayaEstimasi, string statusRental)
        {
            IdRental = idRental;
            IdMobil = idMobil;
            IdPelanggan = idPelanggan;
            TanggalSewa = tanggalSewa;
            TanggalKembaliRencana = tanggalKembaliRencana;
            Jaminan = jaminan;
            TotalBiayaEstimasi = totalBiayaEstimasi;
            StatusRental = statusRental;
        }
    }
}