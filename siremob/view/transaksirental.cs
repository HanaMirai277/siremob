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
using siremob.konfigurasi;
using siremob.model;

namespace siremob.view
{
    public partial class transaksirental : Form
    {
        private transaksirental_serve sewaService = new transaksirental_serve();
        private decimal hargaMobilTerpilih = 0;
        private string currentIdRental = "";

        private ComboBox cmb_jaminan;
        private Label lbl_jaminan;

        public transaksirental()
        {
            InitializeComponent();

            txt_lama_sewa.ReadOnly = true;
            txt_total.ReadOnly = true;
            
            InisialisasiJaminanControl();

            btn_cari.Click += new EventHandler(btnCari_Click);
        }

        private void InisialisasiJaminanControl()
        {
            lbl_jaminan = new Label();
            lbl_jaminan.Text = "Jaminan";
            lbl_jaminan.Font = new Font("Arial", 10F);
            lbl_jaminan.ForeColor = Color.White;
            lbl_jaminan.Location = new Point(15, 310);
            lbl_jaminan.AutoSize = true;

            cmb_jaminan = new ComboBox();
            cmb_jaminan.Location = new Point(15, 335);
            cmb_jaminan.Size = new Size(315, 28);
            cmb_jaminan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_jaminan.Items.Add("KTP");
            cmb_jaminan.Items.Add("KK");
            cmb_jaminan.Items.Add("Kendaraan Pribadi");
            cmb_jaminan.SelectedIndex = -1;

            panel2.Controls.Add(lbl_jaminan);
            panel2.Controls.Add(cmb_jaminan);
        }

        private void AturAksesBerdasarkanRole()
        {
            bool bolehInput = Session.Role == "Karyawan";

            btn_simpan.Enabled = bolehInput;
            cmb_pelanggan.Enabled = bolehInput;
            cmb_mobil.Enabled = bolehInput;
            dtp_tgl_sewa.Enabled = bolehInput;
            dtp_tgl_kembali.Enabled = bolehInput;
            if (cmb_jaminan != null) cmb_jaminan.Enabled = bolehInput;

            lblModeAkses.Visible = !bolehInput;
        }

        private void rental_Load(object sender, EventArgs e)
        {
            dgv_transaksi.AutoGenerateColumns = false;
            dgv_transaksi.Columns["colIdMobil"].DataPropertyName = "id_rental";
            dgv_transaksi.Columns["colPlatNomor"].DataPropertyName = "nama_pelanggan";
            dgv_transaksi.Columns["colMerk"].DataPropertyName = "Mobil";
            dgv_transaksi.Columns["colTipe"].DataPropertyName = "tanggalsewa";
            dgv_transaksi.Columns["colTahun"].DataPropertyName = "tanggalkembali_rencana";
            dgv_transaksi.Columns["colWarna"].DataPropertyName = "totalbiaya_estimasi";
            dgv_transaksi.Columns["colHarga"].DataPropertyName = "statusrental";

            AturAksesBerdasarkanRole();
            RefreshHalaman();
        }

        private void RefreshHalaman()
        {
            try
            {
                currentIdRental = sewaService.GetNextIdRental();
                label1.Text = $"Transaksi Rental - {currentIdRental}";

                dgv_transaksi.DataSource = sewaService.TampilkanDaftarRental();

                DataTable dtPelanggan = sewaService.AmbilSemuaPelanggan();
                cmb_pelanggan.DataSource = dtPelanggan;
                cmb_pelanggan.DisplayMember = "nama_pelanggan";
                cmb_pelanggan.ValueMember = "id_pelanggan";
                cmb_pelanggan.SelectedIndex = -1;

                DataTable dtMobil = sewaService.AmMobilTersedia();
                cmb_mobil.DataSource = dtMobil;
                cmb_mobil.DisplayMember = "merk";
                cmb_mobil.ValueMember = "id_mobil";
                cmb_mobil.SelectedIndex = -1;

                txt_lama_sewa.Clear();
                txt_total.Clear();
                hargaMobilTerpilih = 0;
                if (cmb_jaminan != null) cmb_jaminan.SelectedIndex = -1;

                dtp_tgl_sewa.Value = DateTime.Now;
                dtp_tgl_kembali.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyegarkan halaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HitungEstimasiBiaya()
        {
            if (cmb_mobil.SelectedIndex == -1) return;

            DateTime tglSewa = dtp_tgl_sewa.Value.Date;
            DateTime tglKembali = dtp_tgl_kembali.Value.Date;

            TimeSpan selisih = tglKembali - tglSewa;
            int lamaSewa = selisih.Days;

            if (lamaSewa < 0)
            {
                lamaSewa = 0;
            }

            txt_lama_sewa.Text = lamaSewa.ToString();
            decimal totalBiaya = lamaSewa * hargaMobilTerpilih;
            txt_total.Text = totalBiaya.ToString("F0");
        }

        private void dtp_tgl_sewa_ValueChanged(object sender, EventArgs e)
        {
            HitungEstimasiBiaya();
        }

        private void dtp_tgl_kembali_ValueChanged(object sender, EventArgs e)
        {
            HitungEstimasiBiaya();
        }

        private void cmb_mobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_mobil.SelectedIndex != -1 && cmb_mobil.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cmb_mobil.SelectedItem;
                hargaMobilTerpilih = Convert.ToDecimal(row["harga_sewa"]);
                HitungEstimasiBiaya();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Karyawan")
            {
                MessageBox.Show("Hanya Karyawan (Kasir) yang memiliki hak akses untuk menyimpan transaksi rental!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_pelanggan.SelectedIndex == -1 || cmb_mobil.SelectedIndex == -1 || string.IsNullOrEmpty(txt_total.Text))
            {
                MessageBox.Show("Harap lengkapi data Pelanggan, Mobil, dan Tanggal terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_jaminan.SelectedIndex == -1)
            {
                MessageBox.Show("Gagal Menyimpan! Jaminan (KTP/KK/Kendaraan Pribadi) belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime tglSewa = dtp_tgl_sewa.Value;
            DateTime tglKembali = dtp_tgl_kembali.Value;

            if (tglKembali.Date < tglSewa.Date)
            {
                MessageBox.Show("Tanggal kembali tidak boleh lebih awal dari tanggal sewa!", "Validasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                model.transaksirental objekSewa = new model.transaksirental
                {
                    IdRental = currentIdRental,
                    IdMobil = cmb_mobil.SelectedValue.ToString(),
                    IdPelanggan = cmb_pelanggan.SelectedValue.ToString(),
                    TanggalSewa = tglSewa,
                    TanggalKembaliRencana = tglKembali,
                    TotalBiayaEstimasi = Convert.ToDecimal(txt_total.Text),
                    Jaminan = cmb_jaminan.SelectedItem.ToString(),
                    StatusRental = "Berjalan"
                };

                bool apakahSukses = sewaService.SimpanTransaksiSewaDenganModel(objekSewa);

                if (apakahSukses)
                {
                    MessageBox.Show("Transaksi Rental berhasil disimpan! Status mobil otomatis berubah menjadi 'Disewa'.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshHalaman();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan transaksi! Periksa kembali data Anda.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin membatalkan transaksi ini? Semua data yang diinput akan dibersihkan.", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RefreshHalaman();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txb_cari.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    dgv_transaksi.DataSource = sewaService.TampilkanDaftarRental();
                }
                else
                {
                    dgv_transaksi.DataSource = sewaService.CariTransaksiRental(keyword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}