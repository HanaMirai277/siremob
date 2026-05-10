using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace siremob.konfigurasi
{
    internal class Koneksi : Konfigurasi
    {
        MySqlConnection _con;
        MySqlCommand _com;
        MySqlDataAdapter _adapter;
        string _link = "server=localhost;database=siremob;uid=root;pwd=;";

        public Koneksi()
        {
            _con = new MySqlConnection(_link);
            _com = new MySqlCommand();
            _adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuka koneksi: " + ex.Message);
            }
        }

        void tutupKoneksi()
        {
            _con.Close();
        }

        public override int EksekusiNonQuery(string query)
        {
            int nilai = -1;
            try
            {
                bukaKoneksi();
                _com.Connection = _con;
                _com.CommandText = query;
                nilai = _com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengeksekusi query: " + ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }
            return nilai;
        }

        public override DataTable EksekusiQuery(string query)
        {
            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                _com.Connection = _con;
                _com.CommandText = query;
                _adapter.SelectCommand = _com;
                _adapter.Fill(nilai);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengeksekusi query: " + ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }
            return nilai;
        }
    }
}


