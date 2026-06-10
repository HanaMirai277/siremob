using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siremob.model;

namespace siremob.view
{
    public partial class dashboard : Form
    {
        private Form activeForm = null;

        public dashboard()
        {
            InitializeComponent();
            
            // Wire up event handlers
            this.Load += new EventHandler(dashboard_Load);
            
            btnDashboard.Click += new EventHandler(btnDashboard_Click);
            btnKelolaMobil.Click += new EventHandler(btnKelolaMobil_Click);
            btnCardMobilGo.Click += new EventHandler(btnKelolaMobil_Click);
            
            btnKelolaPelanggan.Click += new EventHandler(btnKelolaPelanggan_Click);
            btnCardPelangganGo.Click += new EventHandler(btnKelolaPelanggan_Click);
            
            btnTransaksi.Click += new EventHandler(btnTransaksi_Click);
            btnPengembalian.Click += new EventHandler(btnPengembalian_Click);
            btnLaporan.Click += new EventHandler(btnLaporan_Click);
            btnKelolaPetugas.Click += new EventHandler(btnKelolaPetugas_Click);
            
            btnKeluar.Click += new EventHandler(btnKeluar_Click);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // Set session display
            lblSessionUser.Text = $"User: {Session.NamaPetugas}\nRole: {Session.Role}";

            // Role-based authorization
            RestrictMenuByRole();
        }

        private void RestrictMenuByRole()
        {
            string role = Session.Role;

            if (role == "Karyawan")
            {
                btnLaporan.Visible = false;
                btnKelolaPetugas.Visible = false;
            }
            else if (role == "Admin")
            {
                btnLaporan.Visible = true;
                btnKelolaPetugas.Visible = false;
            }
            else if (role == "Owner")
            {
                btnLaporan.Visible = true;
                btnKelolaPetugas.Visible = true;
            }
        }

        // Helper to load child Form inside mainPanel
        private void BukaChildForm(Form childForm, string title)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                
                mainPanel.Controls.Add(childForm);
                mainPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

                lblHeaderTitle.Text = title;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka modul: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            homePanel.BringToFront();
            lblHeaderTitle.Text = "Dashboard Utama SIREMOB";
        }

        private void btnKelolaMobil_Click(object sender, EventArgs e)
        {
            BukaChildForm(new mastermobil(), "Manajemen Armada Mobil");
        }

        private void btnKelolaPelanggan_Click(object sender, EventArgs e)
        {
            BukaChildForm(new masterpelanggan(), "Manajemen Data Pelanggan");
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            BukaChildForm(new transaksirental(), "Input Transaksi Rental");
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            BukaChildForm(new pengembalian_pembayaran(), "Pengembalian & Finishing Pembayaran");
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            BukaChildForm(new financial_reports(), "Laporan Keuangan & Omzet Toko");
        }

        private void btnKelolaPetugas_Click(object sender, EventArgs e)
        {
            BukaChildForm(new masterpetugas(), "Manajemen Akun Petugas");
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout dari sistem?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Clear session details
                Session.Clear();

                // Find and show login form
                Form loginForm = Application.OpenForms["login"];
                if (loginForm != null)
                {
                    loginForm.Show();
                    
                    // Clear textboxes on login screen
                    Control[] txtUser = loginForm.Controls.Find("txtUsername", true);
                    Control[] txtPass = loginForm.Controls.Find("txtPassword", true);
                    if (txtUser.Length > 0) ((TextBox)txtUser[0]).Clear();
                    if (txtPass.Length > 0) ((TextBox)txtPass[0]).Clear();
                }
                
                this.Close();
            }
        }
    }
}
