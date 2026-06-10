using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using siremob.model;
using siremob.service;

namespace siremob.view
{
    public partial class mastermobil : Form
    {
        private mastermobil_serve _service;
        private string _fotoPath = "";

        public mastermobil()
        {
            InitializeComponent();
            _service = new mastermobil_serve();
        }

        private void mastermobil_Load(object sender, EventArgs e)
        {
            TampilkanData();
            if (Session.Role == "Karyawan")
            {
                button_Tambah.Enabled = false;
                button_Ubah.Enabled = false;
                button_Hapus.Enabled = false;
                button_Browse.Enabled = false;
                
                tbx_IdMobil.ReadOnly = true;
                tbx_PlatNomor.ReadOnly = true;
                tbx_Merk.ReadOnly = true;
                tbx_Tipe.ReadOnly = true;
                tbx_Warna.ReadOnly = true;
                tbx_Harga.ReadOnly = true;
                nud_Tahun.Enabled = false;
                comboBox_Status.Enabled = false;
            }
        }

        private void TampilkanData()
        {
            try
            {
                dgv_Mobil.AutoGenerateColumns = false;

                dgv_Mobil.Columns["colIdMobil"].DataPropertyName = "id_mobil";
                dgv_Mobil.Columns["colPlatNomor"].DataPropertyName = "platnomor";
                dgv_Mobil.Columns["colMerk"].DataPropertyName = "merk";
                dgv_Mobil.Columns["colTipe"].DataPropertyName = "tipe";
                dgv_Mobil.Columns["colTahun"].DataPropertyName = "tahun";
                dgv_Mobil.Columns["colWarna"].DataPropertyName = "warna";
                dgv_Mobil.Columns["colHarga"].DataPropertyName = "hargasewaperhari"; 
                dgv_Mobil.Columns["colStatus"].DataPropertyName = "statusmobil";

                DataTable dt = _service.TampilData();
                dgv_Mobil.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Menampilkan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbx_IdMobil.Text) ||
                    string.IsNullOrWhiteSpace(tbx_PlatNomor.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Merk.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Tipe.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Warna.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Harga.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_service.CekIdMobil(tbx_IdMobil.Text))
                {
                    MessageBox.Show("ID Mobil sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_service.CekPlatNomor(tbx_PlatNomor.Text))
                {
                    MessageBox.Show("Plat Nomor sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                model.mastermobil mm = new model.mastermobil();
                mm.id_mobil = tbx_IdMobil.Text;
                mm.platnomor = tbx_PlatNomor.Text;
                mm.merk = tbx_Merk.Text;
                mm.tipe = tbx_Tipe.Text;
                mm.tahun = (int)nud_Tahun.Value;
                mm.warna = tbx_Warna.Text;
                mm.hargasewaperhari = decimal.Parse(tbx_Harga.Text);
                mm.statusmobil = comboBox_Status.Text;
                mm.foto = _fotoPath;

                _service.TambahData(mm);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Menambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Ubah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbx_IdMobil.Text))
                {
                    MessageBox.Show("Pilih data yang akan diubah!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbx_PlatNomor.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Merk.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Tipe.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Warna.Text) ||
                    string.IsNullOrWhiteSpace(tbx_Harga.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.mastermobil mm = new model.mastermobil();
                mm.id_mobil = tbx_IdMobil.Text;
                mm.platnomor = tbx_PlatNomor.Text;
                mm.merk = tbx_Merk.Text;
                mm.tipe = tbx_Tipe.Text;
                mm.tahun = (int)nud_Tahun.Value;
                mm.warna = tbx_Warna.Text;
                mm.hargasewaperhari = decimal.Parse(tbx_Harga.Text);
                mm.statusmobil = comboBox_Status.Text;
                mm.foto = string.IsNullOrEmpty(_fotoPath) ? pbx_Foto.ImageLocation : _fotoPath;

                _service.UbahData(mm);
                MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Mengubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbx_IdMobil.Text))
                {
                    MessageBox.Show("Pilih data yang akan dihapus!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _service.HapusData(tbx_IdMobil.Text);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    TampilkanData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Menghapus Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            tbx_IdMobil.Clear();
            tbx_PlatNomor.Clear();
            tbx_Merk.Clear();
            tbx_Tipe.Clear();
            nud_Tahun.Value = 2024;
            tbx_Warna.Clear();
            tbx_Harga.Clear();
            comboBox_Status.SelectedIndex = 0;
            pbx_Foto.Image = null;
            _fotoPath = "";
            tbx_IdMobil.Focus();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _fotoPath = ofd.FileName;
                    MessageBox.Show("Path: " + _fotoPath);
                    pbx_Foto.Text = _fotoPath;
                    pbx_Foto.Image = Image.FromFile(_fotoPath);

                    MessageBox.Show(
                        pbx_Foto.Image == null
                        ? "Image NULL"
                        : "Image BERHASIL DIMUAT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_Mobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_Mobil.Rows[e.RowIndex];
                    tbx_IdMobil.Text = row.Cells["colIdMobil"].Value?.ToString();
                    tbx_PlatNomor.Text = row.Cells["colPlatNomor"].Value?.ToString();
                    tbx_Merk.Text = row.Cells["colMerk"].Value?.ToString();
                    tbx_Tipe.Text = row.Cells["colTipe"].Value?.ToString();
                    nud_Tahun.Value = Convert.ToInt32(row.Cells["colTahun"].Value);
                    tbx_Warna.Text = row.Cells["colWarna"].Value?.ToString();
                    tbx_Harga.Text = row.Cells["colHarga"].Value?.ToString();
                    comboBox_Status.Text = row.Cells["colStatus"].Value?.ToString();

                    string fotoPath = row.Cells["colFoto"].Value?.ToString() ?? "";
                    pbx_Foto.Text = fotoPath;

                    if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                    {
                        pbx_Foto.Image = Image.FromFile(fotoPath);
                    }
                    else
                    {
                        pbx_Foto.Image = null;
                    }

                    _fotoPath = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memilih Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cari_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbx_Cari.Text))
                {
                    TampilkanData();
                }
                else
                {
                    dgv_Mobil.AutoGenerateColumns = false;

                    DataTable dt = _service.CariData(tbx_Cari.Text);
                    dgv_Mobil.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Mencari Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Foto_Click(object sender, EventArgs e)
        {

        }

        private void tbx_IdMobil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
