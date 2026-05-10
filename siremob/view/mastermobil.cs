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
        }

        private void TampilkanData()
        {
            try
            {
                DataTable dt = _service.TampilData();
                dataGridView_Mobil.DataSource = dt;
                dataGridView_Mobil.Columns[0].HeaderText = "ID Mobil";
                dataGridView_Mobil.Columns[1].HeaderText = "Plat Nomor";
                dataGridView_Mobil.Columns[2].HeaderText = "Merk";
                dataGridView_Mobil.Columns[3].HeaderText = "Tipe";
                dataGridView_Mobil.Columns[4].HeaderText = "Tahun";
                dataGridView_Mobil.Columns[5].HeaderText = "Warna";
                dataGridView_Mobil.Columns[6].HeaderText = "Harga/Hari";
                dataGridView_Mobil.Columns[7].HeaderText = "Status";
                dataGridView_Mobil.Columns[8].HeaderText = "Foto";
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
                if (string.IsNullOrWhiteSpace(textBox_IdMobil.Text) ||
                    string.IsNullOrWhiteSpace(textBox_PlatNomor.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Merk.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Tipe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Warna.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Harga.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_service.CekIdMobil(textBox_IdMobil.Text))
                {
                    MessageBox.Show("ID Mobil sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_service.CekPlatNomor(textBox_PlatNomor.Text))
                {
                    MessageBox.Show("Plat Nomor sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                model.mastermobil mm = new model.mastermobil();
                mm.id_mobil = textBox_IdMobil.Text;
                mm.platnomor = textBox_PlatNomor.Text;
                mm.merk = textBox_Merk.Text;
                mm.tipe = textBox_Tipe.Text;
                mm.tahun = (int)numericUpDown_Tahun.Value;
                mm.warna = textBox_Warna.Text;
                mm.hargasewaperhari = decimal.Parse(textBox_Harga.Text);
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
                if (string.IsNullOrWhiteSpace(textBox_IdMobil.Text))
                {
                    MessageBox.Show("Pilih data yang akan diubah!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox_PlatNomor.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Merk.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Tipe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Warna.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Harga.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.mastermobil mm = new model.mastermobil();
                mm.id_mobil = textBox_IdMobil.Text;
                mm.platnomor = textBox_PlatNomor.Text;
                mm.merk = textBox_Merk.Text;
                mm.tipe = textBox_Tipe.Text;
                mm.tahun = (int)numericUpDown_Tahun.Value;
                mm.warna = textBox_Warna.Text;
                mm.hargasewaperhari = decimal.Parse(textBox_Harga.Text);
                mm.statusmobil = comboBox_Status.Text;
                mm.foto = string.IsNullOrEmpty(_fotoPath) ? textBox_Foto.Text : _fotoPath;

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
                if (string.IsNullOrWhiteSpace(textBox_IdMobil.Text))
                {
                    MessageBox.Show("Pilih data yang akan dihapus!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _service.HapusData(textBox_IdMobil.Text);
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
            textBox_IdMobil.Clear();
            textBox_PlatNomor.Clear();
            textBox_Merk.Clear();
            textBox_Tipe.Clear();
            numericUpDown_Tahun.Value = 2024;
            textBox_Warna.Clear();
            textBox_Harga.Clear();
            comboBox_Status.SelectedIndex = 0;
            textBox_Foto.Clear();
            pictureBox_Foto.Image = null;
            _fotoPath = "";
            textBox_IdMobil.Focus();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Pilih Foto Mobil";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _fotoPath = ofd.FileName;
                    textBox_Foto.Text = Path.GetFileName(ofd.FileName);
                    pictureBox_Foto.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memilih Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Mobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_Mobil.Rows[e.RowIndex];
                    textBox_IdMobil.Text = row.Cells[0].Value.ToString();
                    textBox_PlatNomor.Text = row.Cells[1].Value.ToString();
                    textBox_Merk.Text = row.Cells[2].Value.ToString();
                    textBox_Tipe.Text = row.Cells[3].Value.ToString();
                    numericUpDown_Tahun.Value = Convert.ToInt32(row.Cells[4].Value);
                    textBox_Warna.Text = row.Cells[5].Value.ToString();
                    textBox_Harga.Text = row.Cells[6].Value.ToString();
                    comboBox_Status.Text = row.Cells[7].Value.ToString();

                    string fotoPath = row.Cells[8].Value.ToString();
                    textBox_Foto.Text = fotoPath;

                    if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                    {
                        pictureBox_Foto.Image = Image.FromFile(fotoPath);
                    }
                    else
                    {
                        pictureBox_Foto.Image = null;
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
                if (string.IsNullOrWhiteSpace(textBox_Cari.Text))
                {
                    TampilkanData();
                }
                else
                {
                    DataTable dt = _service.CariData(textBox_Cari.Text);
                    dataGridView_Mobil.DataSource = dt;
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
    }
}
