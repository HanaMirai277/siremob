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
    internal class mastermobil_serve
    {
        private Koneksi _koneksi;

        public mastermobil_serve()
        {
            _koneksi = new Koneksi();
        }

        public DataTable TampilData()
        {
            string query = "SELECT * FROM Mobil";
            return _koneksi.EksekusiQuery(query);
        }

        public DataTable CariData(string cari)
        {
            string query = "SELECT * FROM Mobil WHERE id_mobil LIKE '%" + cari + "%' OR platnomor LIKE '%" + cari + "%' OR merk LIKE '%" + cari + "%'";
            return _koneksi.EksekusiQuery(query);
        }

        public void TambahData(mastermobil mm)
        {
            string query = "INSERT INTO Mobil (id_mobil, platnomor, merk, tipe, tahun, warna, hargasewaperhari, statusmobil, foto) VALUES ('" + mm.id_mobil + "', '" + mm.platnomor + "', '" + mm.merk + "', '" + mm.tipe + "', " + mm.tahun + ", '" + mm.warna + "', " + mm.hargasewaperhari + ", '" + mm.statusmobil + "', '" + mm.foto + "')";
            _koneksi.EksekusiNonQuery(query);
        }

        public void UbahData(mastermobil mm)
        {
            string query = "UPDATE Mobil SET platnomor = '" + mm.platnomor + "', merk = '" + mm.merk + "', tipe = '" + mm.tipe + "', tahun = " + mm.tahun + ", warna = '" + mm.warna + "', hargasewaperhari = " + mm.hargasewaperhari + ", statusmobil = '" + mm.statusmobil + "', foto = '" + mm.foto + "' WHERE id_mobil = '" + mm.id_mobil + "'";
            _koneksi.EksekusiNonQuery(query);
        }

        public void HapusData(string id_mobil)
        {
            string query = "DELETE FROM Mobil WHERE id_mobil = '" + id_mobil + "'";
            _koneksi.EksekusiNonQuery(query);
        }

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
    }
}
