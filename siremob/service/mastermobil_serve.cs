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
        public string AmbilKodeOtomatis()
        {
            string kodeBaru = "M001"; 
            string query = "SELECT MAX(RIGHT(id_mobil, 3)) FROM Mobil";

            try
            {
                DataTable dt = _koneksi.EksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    int noUrut = Convert.ToInt32(dt.Rows[0][0]) + 1;
                    kodeBaru = "M" + noUrut.ToString("d3");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuat kode otomatis di layer service: " + ex.Message);
            }

            return kodeBaru;
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
            string amanFotoPath = mm.foto.Replace("\\", "\\\\");

            string query = "INSERT INTO Mobil (id_mobil, platnomor, merk, tipe, tahun, warna, hargasewaperhari, statusmobil, foto) " +
                           "VALUES ('" + mm.id_mobil + "', '" + mm.platnomor + "', '" + mm.merk + "', '" + mm.tipe + "', " + mm.tahun + ", " +
                           "'" + mm.warna + "', " + mm.hargasewaperhari + ", '" + mm.statusmobil + "', '" + amanFotoPath + "')";

            _koneksi.EksekusiNonQuery(query);
        }

        public void UbahData(mastermobil mm)
        {
            string amanFotoPath = mm.foto.Replace("\\", "\\\\");

            string query = "UPDATE Mobil SET platnomor = '" + mm.platnomor + "', merk = '" + mm.merk + "', tipe = '" + mm.tipe + "', " +
                           "tahun = " + mm.tahun + ", warna = '" + mm.warna + "', hargasewaperhari = " + mm.hargasewaperhari + ", " +
                           "statusmobil = '" + mm.statusmobil + "', foto = '" + amanFotoPath + "' WHERE id_mobil = '" + mm.id_mobil + "'";

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