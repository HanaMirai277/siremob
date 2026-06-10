using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siremob.konfigurasi;
using System.Data;
using System.Drawing.Text;

namespace siremob.view
{
    public partial class pengembalian_pembayaran : Form
    {
        Koneksi koneksi = new Koneksi();

        public pengembalian_pembayaran()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            try
            {
                string query = "SELECT * FROM pengembalian";

                DataTable dt = koneksi.EksekusiQuery(query);

                dgv_pengembalian.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public pengembalian_pembayaran()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biayarental_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idpengembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void pengembalian_pembayaran_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        private void btn_batal_Click(object sender, EventArgs e)
        {

        }
    }
}
