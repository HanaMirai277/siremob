using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siremob.view
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            // Bind events dynamically
            btnKelolaMobil.Click += new EventHandler(btnKelolaMobil_Click);
            btnCardMobilGo.Click += new EventHandler(btnKelolaMobil_Click);

            btnKelolaPelanggan.Click += new EventHandler(btnKelolaPelanggan_Click);
            btnCardPelangganGo.Click += new EventHandler(btnKelolaPelanggan_Click);

            btnKeluar.Click += new EventHandler(btnKeluar_Click);
        }

        private void btnKelolaMobil_Click(object sender, EventArgs e)
        {
            try
            {
                mastermobil mobilForm = new mastermobil();
                mobilForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka modul mobil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKelolaPelanggan_Click(object sender, EventArgs e)
        {
            try
            {
                masterpelanggan pelangganForm = new masterpelanggan();
                pelangganForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka modul pelanggan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
