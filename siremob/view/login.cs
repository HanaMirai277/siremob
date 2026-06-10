using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siremob.service;
using siremob.model;

namespace siremob.view
{
    public partial class login : Form
    {
        private login_serve loginService;

        public login()
        {
            InitializeComponent();
            loginService = new login_serve();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isSuccess = loginService.VerifikasiLogin(username, password);

                if (isSuccess)
                {
                    MessageBox.Show($"Selamat datang {Session.NamaPetugas}! Anda login sebagai {Session.Role}.", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Show dashboard
                    dashboard dashboardForm = new dashboard();
                    dashboardForm.Show();

                    // Hide login form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
