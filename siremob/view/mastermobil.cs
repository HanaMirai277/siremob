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
            SetIdMobilOtomatis();
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
                TampilkanKotakError("Gagal Menampilkan Data", ex.Message);
            }
        }

        private void SetIdMobilOtomatis()
        {
            try
            {
                string kodeOtomatis = _service.AmbilKodeOtomatis();

                tbx_IdMobil.Text = kodeOtomatis;
                tbx_IdMobil.ReadOnly = true;
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Generate ID Otomatis", ex.Message);
            }
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApakahFormKosong())
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

                model.mastermobil mm = AmbilDataDariForm();

                _service.TambahData(mm);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Menambah Data", ex.Message);
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

                if (ApakahFormKosong())
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.mastermobil mm = AmbilDataDariForm();


                if (string.IsNullOrEmpty(_fotoPath))
                {
                    mm.foto = pbx_Foto.Text;
                }

                _service.UbahData(mm);
                MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Mengubah Data", ex.Message);
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
                    ResetSesiGambar();

                    _service.HapusData(tbx_IdMobil.Text);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BersihkanForm();
                    TampilkanData();
                }
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Menghapus Data", ex.Message);
            }
        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _fotoPath = ofd.FileName;
                        MuatGambarSecaraAman(_fotoPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat file gambar: " + ex.Message, "Error Gambar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Mobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
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

                string fotoPathDariGrid = row.Cells["colFoto"].Value?.ToString() ?? "";
                MuatGambarSecaraAman(fotoPathDariGrid);

                _fotoPath = ""; 
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Mengambil Data dari Tabel", ex.Message);
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
                    DataTable dt = _service.CariData(tbx_Cari.Text.Trim());
                    dgv_Mobil.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                TampilkanKotakError("Gagal Mencari Data", ex.Message);
            }
        }

        private model.mastermobil AmbilDataDariForm()
        {
            decimal.TryParse(tbx_Harga.Text, out decimal hargaSewa);

            model.mastermobil mm = new model.mastermobil();
            mm.id_mobil = tbx_IdMobil.Text.Trim();
            mm.platnomor = tbx_PlatNomor.Text.Trim();
            mm.merk = tbx_Merk.Text.Trim();
            mm.tipe = tbx_Tipe.Text.Trim();
            mm.tahun = (int)nud_Tahun.Value;
            mm.warna = tbx_Warna.Text.Trim();
            mm.hargasewaperhari = hargaSewa;
            mm.statusmobil = comboBox_Status.Text;
            mm.foto = _fotoPath;
            return mm;
        }

        private bool ApakahFormKosong()
        {
            return string.IsNullOrWhiteSpace(tbx_IdMobil.Text) ||
                   string.IsNullOrWhiteSpace(tbx_PlatNomor.Text) ||
                   string.IsNullOrWhiteSpace(tbx_Merk.Text) ||
                   string.IsNullOrWhiteSpace(tbx_Tipe.Text) ||
                   string.IsNullOrWhiteSpace(tbx_Warna.Text) ||
                   string.IsNullOrWhiteSpace(tbx_Harga.Text);
        }

        private void MuatGambarSecaraAman(string path)
        {
            ResetSesiGambar();
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                pbx_Foto.Text = path;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pbx_Foto.Image = Image.FromStream(fs);
                }
            }
        }

        private void ResetSesiGambar()
        {
            if (pbx_Foto.Image != null)
            {
                pbx_Foto.Image.Dispose();
                pbx_Foto.Image = null;
            }
            pbx_Foto.Text = "";
        }

        private void BersihkanForm()
        {
            tbx_IdMobil.Clear();
            tbx_PlatNomor.Clear();
            tbx_Merk.Clear();
            tbx_Tipe.Clear();
            nud_Tahun.Value = DateTime.Now.Year;
            tbx_Warna.Clear();
            tbx_Harga.Clear();
            if (comboBox_Status.Items.Count > 0) comboBox_Status.SelectedIndex = 0;

            ResetSesiGambar();
            _fotoPath = "";

            SetIdMobilOtomatis();

            tbx_PlatNomor.Focus();
        }

        private void TampilkanKotakError(string konteks, string pesan)
        {
            MessageBox.Show("Error: " + pesan, konteks, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox_Foto_Click(object sender, EventArgs e) { }
        private void tbx_IdMobil_TextChanged(object sender, EventArgs e) { }
    }
}