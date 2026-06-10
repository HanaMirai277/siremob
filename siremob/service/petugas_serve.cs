using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using siremob.konfigurasi;

namespace siremob.service
{
    internal class petugas_serve
    {
        private Koneksi koneksiDb = new Koneksi();

        // 1. TAMPIL DATA
        public DataTable TampilData()
        {
            string query = "SELECT id_petugas, nama_petugas, username, role FROM petugas";
            return koneksiDb.EksekusiQuery(query);
        }

        // 2. CARI DATA
        public DataTable CariData(string cari)
        {
            string escapedCari = cari.Replace("'", "''");
            string query = $"SELECT id_petugas, nama_petugas, username, role FROM petugas WHERE id_petugas LIKE '%{escapedCari}%' OR nama_petugas LIKE '%{escapedCari}%' OR username LIKE '%{escapedCari}%'";
            return koneksiDb.EksekusiQuery(query);
        }

        // 3. TAMBAH DATA (WITH HASHED PASSWORD)
        public bool TambahData(string id, string nama, string username, string password, string role)
        {
            string hashedPassword = login_serve.HashPassword(password);
            string escapedNama = nama.Replace("'", "''");
            string escapedUsername = username.Replace("'", "''");

            string query = $@"INSERT INTO petugas (id_petugas, nama_petugas, username, password, role) 
                             VALUES ('{id}', '{escapedNama}', '{escapedUsername}', '{hashedPassword}', '{role}')";

            return koneksiDb.EksekusiNonQuery(query) > 0;
        }

        // 4. UBAH DATA (WITH CONDITIONAL PASSWORD UPDATE)
        public bool UbahData(string id, string nama, string username, string password, string role)
        {
            string escapedNama = nama.Replace("'", "''");
            string escapedUsername = username.Replace("'", "''");
            string query;

            if (string.IsNullOrEmpty(password))
            {
                // Do not update password if left blank
                query = $@"UPDATE petugas SET nama_petugas = '{escapedNama}', username = '{escapedUsername}', role = '{role}' 
                           WHERE id_petugas = '{id}'";
            }
            else
            {
                string hashedPassword = login_serve.HashPassword(password);
                query = $@"UPDATE petugas SET nama_petugas = '{escapedNama}', username = '{escapedUsername}', password = '{hashedPassword}', role = '{role}' 
                           WHERE id_petugas = '{id}'";
            }

            return koneksiDb.EksekusiNonQuery(query) > 0;
        }

        // 5. HAPUS DATA
        public bool HapusData(string id)
        {
            string query = $"DELETE FROM petugas WHERE id_petugas = '{id}'";
            return koneksiDb.EksekusiNonQuery(query) > 0;
        }

        // 6. VALIDATE ID DUPLICATION
        public bool CekIdPetugas(string id)
        {
            string query = $"SELECT COUNT(*) FROM petugas WHERE id_petugas = '{id}'";
            DataTable dt = koneksiDb.EksekusiQuery(query);
            return dt != null && dt.Rows.Count > 0 && int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        // 7. VALIDATE USERNAME DUPLICATION
        public bool CekUsername(string username, string excludeId = "")
        {
            string escapedUsername = username.Replace("'", "''");
            string query = $"SELECT COUNT(*) FROM petugas WHERE username = '{escapedUsername}'";
            if (!string.IsNullOrEmpty(excludeId))
            {
                query += $" AND id_petugas != '{excludeId}'";
            }
            DataTable dt = koneksiDb.EksekusiQuery(query);
            return dt != null && dt.Rows.Count > 0 && int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        // 8. GET NEXT ID AUTOMATICALLY
        public string GetNextIdPetugas()
        {
            try
            {
                string query = "SELECT id_petugas FROM petugas ORDER BY id_petugas DESC LIMIT 1";
                DataTable dt = koneksiDb.EksekusiQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int maxId = int.Parse(dt.Rows[0][0].ToString());
                    maxId++;
                    return maxId.ToString("D3");
                }
            }
            catch { }
            return "001";
        }
    }
}
