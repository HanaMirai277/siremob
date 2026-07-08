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
using siremob.service;

namespace siremob.view
{
    public partial class masterpelanggan : Form
    {
        private masterpelanggan_serve _service;
        private TextBox _fallbackNoSIM;

        public masterpelanggan()
        {
            InitializeComponent();
            _service = new masterpelanggan_serve();

            // Set ID Pelanggan to read-only so it's managed automatically
            textBox1.ReadOnly = true;

            // Bind event handlers dynamically to avoid modifying the designer file
            this.Load += new EventHandler(masterpelanggan_Load);
            button_Tambah.Click += new EventHandler(button_Tambah_Click);
            button_Ubah.Click += new EventHandler(button_Ubah_Click);
            button_Hapus.Click += new EventHandler(button_Hapus_Click);
            button_Batal.Click += new EventHandler(button_Batal_Click);
            button_Cari.Click += new EventHandler(button_Cari_Click);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        // TextBox untuk input No SIM (asumsi digunakan di UI).
        // Karena tidak boleh mengubah desain form, kita resolusi TextBox secara dinamis berdasarkan nama
        // control 'textBox_NoSIM' atau 'textBox_sim' di form. Jika tidak ditemukan, fallback ke objek TextBox lokal.
        private TextBox TextBoxNoSIM
        {
            get
            {
                Control[] controls = this.Controls.Find("textBox_NoSIM", true);
                if (controls.Length > 0 && controls[0] is TextBox tb)
                {
                    return tb;
                }

                controls = this.Controls.Find("textBox_sim", true);
                if (controls.Length > 0 && controls[0] is TextBox tb2)
                {
                    return tb2;
                }

                if (_fallbackNoSIM == null)
                {
                    _fallbackNoSIM = new TextBox();
                    _fallbackNoSIM.Name = "textBox_NoSIM";
                }
                return _fallbackNoSIM;
            }
        }

        private void AturAksesBerdasarkanRole()
        {
            bool bolehKelola = Session.Role == "Karyawan";

            button_Tambah.Enabled = bolehKelola;
            button_Ubah.Enabled = bolehKelola;
            button_Hapus.Enabled = bolehKelola;

            // Kunci semua field input agar non-karyawan tidak bisa mengubah data pelanggan
            textBox1.ReadOnly = true; // Selalu read only untuk ID otomatis
            textBox2.ReadOnly = !bolehKelola;
            textBox3.ReadOnly = !bolehKelola;
            textBox4.ReadOnly = !bolehKelola;
            textBox5.ReadOnly = !bolehKelola;
            TextBoxNoSIM.ReadOnly = !bolehKelola;

            // Buat label status dinamis di header panel jika belum ada
            Control[] lblAkses = this.Controls.Find("lblModeAkses", true);
            if (lblAkses.Length > 0 && lblAkses[0] is Label lbl)
            {
                lbl.Text = "Mode: Lihat Saja (Read Only)";
                lbl.Visible = !bolehKelola;
            }
            else
            {
                Control[] panels = this.Controls.Find("panel1", true);
                if (panels.Length > 0 && panels[0] is Panel p)
                {
                    Label dynamicLabel = new Label();
                    dynamicLabel.Name = "lblModeAkses";
                    dynamicLabel.Text = "Mode: Lihat Saja (Read Only)";
                    dynamicLabel.BackColor = Color.FromArgb(200, 80, 80);
                    dynamicLabel.ForeColor = Color.White;
                    dynamicLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                    dynamicLabel.Location = new Point(1080, 30);
                    dynamicLabel.AutoSize = true;
                    dynamicLabel.Padding = new Padding(8, 4, 8, 4);
                    dynamicLabel.Visible = !bolehKelola;
                    p.Controls.Add(dynamicLabel);
                }
            }
        }

        private void masterpelanggan_Load(object sender, EventArgs e)
        {
            TampilkanData();
            textBox1.Text = _service.GetNextIdPelanggan();
            AturAksesBerdasarkanRole();
        }

        private void TampilkanData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns["idpelanggan"].DataPropertyName = "id_pelanggan";
                dataGridView1.Columns["nik"].DataPropertyName = "nik";
                dataGridView1.Columns["nama"].DataPropertyName = "nama";
                dataGridView1.Columns["no"].DataPropertyName = "no_hp";
                dataGridView1.Columns["alamat"].DataPropertyName = "alamat";

                DataTable dt = _service.TampilData();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fungsi SimpanDataPenyewa() untuk menyimpan data ke database
        public void SimpanDataPenyewa()
        {
            try
            {
                // Cek apakah control TextBox untuk No SIM terpasang di UI
                bool isNoSIMControlPresent = this.Controls.Find("textBox_NoSIM", true).Length > 0 || 
                                             this.Controls.Find("textBox_sim", true).Length > 0;

                // Form input validation (checking for empty fields)
                if (string.IsNullOrWhiteSpace(textBox1.Text) || // ID Pelanggan
                    string.IsNullOrWhiteSpace(textBox2.Text) || // NIK
                    string.IsNullOrWhiteSpace(textBox3.Text) || // Nama Pelanggan
                    string.IsNullOrWhiteSpace(textBox4.Text) || // No. Telepon / HP
                    string.IsNullOrWhiteSpace(textBox5.Text) || // Alamat
                    (isNoSIMControlPresent && string.IsNullOrWhiteSpace(TextBoxNoSIM.Text))) // No SIM (jika ada di UI)
                {
                    string msg = isNoSIMControlPresent 
                        ? "Semua field (ID Pelanggan, NIK, Nama, No HP, Alamat, dan No SIM) harus diisi!"
                        : "Semua field (ID Pelanggan, NIK, Nama, No HP, dan Alamat) harus diisi!";
                    MessageBox.Show(msg, "Validasi Form Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check duplicate ID Pelanggan
                if (_service.CekIdPelanggan(textBox1.Text))
                {
                    MessageBox.Show("ID Pelanggan sudah terdaftar!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check duplicate NIK
                if (_service.CekNik(textBox2.Text))
                {
                    MessageBox.Show("NIK sudah terdaftar!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construct model
                model.masterpelanggan mp = new model.masterpelanggan();
                mp.id_pelanggan = textBox1.Text;
                mp.nik = textBox2.Text;
                mp.nama = textBox3.Text;
                mp.no_hp = textBox4.Text;
                mp.alamat = textBox5.Text;
                mp.no_sim = isNoSIMControlPresent ? TextBoxNoSIM.Text : "-";

                // Save to database via service
                _service.TambahData(mp);
                MessageBox.Show("Data penyewa/pelanggan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh form and grid
                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Karyawan")
            {
                MessageBox.Show("Hanya Karyawan (Kasir) yang memiliki hak akses untuk menambah data pelanggan!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SimpanDataPenyewa();
        }

        private void button_Ubah_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Karyawan")
            {
                MessageBox.Show("Hanya Karyawan (Kasir) yang memiliki hak akses untuk mengubah data pelanggan!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Pilih data yang akan diubah!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cek apakah control TextBox untuk No SIM terpasang di UI
                bool isNoSIMControlPresent = this.Controls.Find("textBox_NoSIM", true).Length > 0 || 
                                             this.Controls.Find("textBox_sim", true).Length > 0;

                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    (isNoSIMControlPresent && string.IsNullOrWhiteSpace(TextBoxNoSIM.Text)))
                {
                    string msg = isNoSIMControlPresent 
                        ? "Semua field (NIK, Nama, No HP, Alamat, dan No SIM) harus diisi!"
                        : "Semua field (NIK, Nama, No HP, dan Alamat) harus diisi!";
                    MessageBox.Show(msg, "Validasi Form Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.masterpelanggan mp = new model.masterpelanggan();
                mp.id_pelanggan = textBox1.Text;
                mp.nik = textBox2.Text;
                mp.nama = textBox3.Text;
                mp.no_hp = textBox4.Text;
                mp.alamat = textBox5.Text;
                mp.no_sim = isNoSIMControlPresent ? TextBoxNoSIM.Text : "-";

                _service.UbahData(mp);
                MessageBox.Show("Data penyewa/pelanggan berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BersihkanForm();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Karyawan")
            {
                MessageBox.Show("Hanya Karyawan (Kasir) yang memiliki hak akses untuk menghapus data pelanggan!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Pilih data yang akan dihapus!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _service.HapusData(textBox1.Text);
                    MessageBox.Show("Data penyewa/pelanggan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    TampilkanData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void button_Cari_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    TampilkanData();
                }
                else
                {
                    DataTable dt = _service.CariData(textBox6.Text);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["idpelanggan"].Value?.ToString() ?? "";
                    textBox2.Text = row.Cells["nik"].Value?.ToString() ?? "";
                    textBox3.Text = row.Cells["nama"].Value?.ToString() ?? "";
                    textBox4.Text = row.Cells["no"].Value?.ToString() ?? "";
                    textBox5.Text = row.Cells["alamat"].Value?.ToString() ?? "";

                    if (row.DataBoundItem is DataRowView drv)
                    {
                        if (drv.Row.Table.Columns.Contains("no_sim"))
                        {
                            TextBoxNoSIM.Text = drv["no_sim"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BersihkanForm()
        {
            textBox1.Text = _service.GetNextIdPelanggan();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            TextBoxNoSIM.Clear();
            textBox2.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
