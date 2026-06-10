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
    public partial class masterpetugas : Form
    {
        private petugas_serve petugasService = new petugas_serve();

        public masterpetugas()
        {
            InitializeComponent();
            
            // Wire up event handlers dynamically
            this.Load += new EventHandler(masterpetugas_Load);
            btnTambah.Click += new EventHandler(btnTambah_Click);
            btnUbah.Click += new EventHandler(btnUbah_Click);
            btnHapus.Click += new EventHandler(btnHapus_Click);
            btnBatal.Click += new EventHandler(btnBatal_Click);
            btnCari.Click += new EventHandler(btnCari_Click);
            dgvPetugas.CellClick += new DataGridViewCellEventHandler(dgvPetugas_CellClick);
        }

        private void masterpetugas_Load(object sender, EventArgs e)
        {
            TampilkanData();
            BersihkanForm();
        }

        private void TampilkanData()
        {
            try
            {
                dgvPetugas.AutoGenerateColumns = false;
                dgvPetugas.Columns["colId"].DataPropertyName = "id_petugas";
                dgvPetugas.Columns["colNama"].DataPropertyName = "nama_petugas";
                dgvPetugas.Columns["colUsername"].DataPropertyName = "username";
                dgvPetugas.Columns["colRole"].DataPropertyName = "role";

                DataTable dt = petugasService.TampilData();
                dgvPetugas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data petugas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BersihkanForm()
        {
            txtId.Text = petugasService.GetNextIdPetugas();
            txtId.ReadOnly = true;
            txtNama.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0; // Default: Karyawan
            lblPassHelp.Visible = false;
            
            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            
            txtNama.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nama = txtNama.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.Text;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field input wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (petugasService.CekIdPetugas(id))
                {
                    MessageBox.Show("ID Petugas sudah terdaftar!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (petugasService.CekUsername(username))
                {
                    MessageBox.Show("Username sudah terpakai!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isSuccess = petugasService.TambahData(id, nama, username, password, role);
                if (isSuccess)
                {
                    MessageBox.Show("Akun petugas berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanData();
                    BersihkanForm();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan petugas.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistem Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nama = txtNama.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // optional on update
            string role = cmbRole.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("ID, Nama, dan Username wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (petugasService.CekUsername(username, id))
                {
                    MessageBox.Show("Username sudah terpakai oleh akun lain!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isSuccess = petugasService.UbahData(id, nama, username, password, role);
                if (isSuccess)
                {
                    MessageBox.Show("Akun petugas berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanData();
                    BersihkanForm();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data petugas.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistem Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Pilih data petugas terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == Session.IdPetugas)
            {
                MessageBox.Show("Anda tidak bisa menghapus akun Anda sendiri yang sedang aktif digunakan!", "Keamanan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Apakah Anda yakin ingin menghapus akun petugas ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    bool isSuccess = petugasService.HapusData(id);
                    if (isSuccess)
                    {
                        MessageBox.Show("Akun petugas berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilkanData();
                        BersihkanForm();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus petugas.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistem Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtCari.Text.Trim();
                if (string.IsNullOrEmpty(key))
                {
                    TampilkanData();
                }
                else
                {
                    DataTable dt = petugasService.CariData(key);
                    dgvPetugas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPetugas.Rows[e.RowIndex];
                txtId.Text = row.Cells["colId"].Value?.ToString();
                txtNama.Text = row.Cells["colNama"].Value?.ToString();
                txtUsername.Text = row.Cells["colUsername"].Value?.ToString();
                cmbRole.Text = row.Cells["colRole"].Value?.ToString();
                
                txtPassword.Clear(); // clear for security, let them write new if they want to change
                lblPassHelp.Visible = true;

                btnTambah.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }
    }
}
