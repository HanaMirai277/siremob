using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using siremob.konfigurasi;
using siremob.model;

namespace siremob.service
{
    internal class login_serve
    {
        private Koneksi koneksiDb = new Koneksi();

        public login_serve()
        {
            SeedPetugasTabel();
        }

        // SHA-256 hashing helper
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Check if database petugas table is empty and seed default accounts
        private void SeedPetugasTabel()
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM petugas";
                DataTable dt = koneksiDb.EksekusiQuery(checkQuery);
                if (dt != null && dt.Rows.Count > 0 && int.Parse(dt.Rows[0][0].ToString()) == 0)
                {
                    // Generate SHA256 hashes of passwords
                    string hashOwner = HashPassword("owner");
                    string hashAdmin = HashPassword("admin");
                    string hashKasir = HashPassword("kasir");

                    string seedQuery = $@"
                        INSERT INTO petugas (id_petugas, nama_petugas, username, password, role) VALUES 
                        ('001', 'Owner Siremob', 'owner', '{hashOwner}', 'Owner'),
                        ('002', 'Admin Siremob', 'admin', '{hashAdmin}', 'Admin'),
                        ('003', 'Kasir Siremob', 'kasir', '{hashKasir}', 'Karyawan')";

                    koneksiDb.EksekusiNonQuery(seedQuery);
                }
            }
            catch (Exception)
            {
                // Ignore errors if DB is offline during constructor initialization
            }
        }

        // Validate user login credentials
        public bool VerifikasiLogin(string username, string password)
        {
            try
            {
                string hashedPassword = HashPassword(password);
                string escapedUsername = username.Replace("'", "''");
                
                string query = $"SELECT * FROM petugas WHERE username = '{escapedUsername}' AND password = '{hashedPassword}'";
                DataTable dt = koneksiDb.EksekusiQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Session.IdPetugas = row["id_petugas"].ToString();
                    Session.NamaPetugas = row["nama_petugas"].ToString();
                    Session.Username = row["username"].ToString();
                    Session.Role = row["role"].ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error login verification: " + ex.Message);
            }
            return false;
        }
    }
}
