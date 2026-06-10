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
namespace siremob.view
{
    public partial class transaksirental : Form
    {
        // Instansiasi class service transaksi
        private transaksirental_serve sewaService = new transaksirental_serve();

        // Variabel untuk menyimpan harga per hari mobil yang dipilih
        private decimal hargaMobilTerpilih = 0;

        public transaksirental()
        {
            InitializeComponent();
        }

        // 1. EVENT SAAT FORM PERTAMA KALI DIBUKA
        private void rental_Load(object sender, EventArgs e)
        {
            RefreshHalaman();
        }

        // Fungsi untuk mengosongkan inputan dan menyegarkan tabel
        private void RefreshHalaman()
        {
            try
            {
                // Tampilkan data riwayat transaksi di DataGridView
                dgv_transaksi.DataSource = sewaService.TampilkanDaftarRental();

                // Isi ComboBox Pelanggan
                DataTable dtPelanggan = sewaService.AmbilSemuaPelanggan();
                cmb_pelanggan.DataSource = dtPelanggan;
                cmb_pelanggan.DisplayMember = "nama_pelanggan";
                cmb_pelanggan.ValueMember = "id_pelanggan";
                cmb_pelanggan.SelectedIndex = -1; // Kosongkan pilihan awal

                // Isi ComboBox Mobil (Hanya yang berstatus 'Tersedia')
                DataTable dtMobil = sewaService.AmbilMobilTersedia();
                cmb_mobil.DataSource = dtMobil;
                cmb_mobil.DisplayMember = "merk";
                cmb_mobil.ValueMember = "id_mobil";
                cmb_mobil.SelectedIndex = -1; // Kosongkan pilihan awal

                // Reset nilai inputan
                txt_lama_sewa.Clear();
                txt_total.Clear();
                hargaMobilTerpilih = 0;

                // Set tanggal ke hari ini
                dtp_tgl_sewa.Value = DateTime.Now;
                dtp_tgl_kembali.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyegarkan halaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. LOGIKA HITUNG OTOMATIS LAMA SEWA & TOTAL BIAYA
        private void HitungEstimasiBiaya()
        {
            // Validasi jika mobil belum dipilih, jangan hitung dulu
            if (cmb_mobil.SelectedIndex == -1) return;

            DateTime tglSewa = dtp_tgl_sewa.Value.Date;
            DateTime tglKembali = dtp_tgl_kembali.Value.Date;

            // Hitung selisih hari
            TimeSpan selisih = tglKembali - tglSewa;
            int lamaSewa = selisih.Days;

            // Mencegah nilai minus jika tanggal kembali lebih awal dari tanggal sewa
            if (lamaSewa < 0)
            {
                lamaSewa = 0;
            }

            txt_lama_sewa.Text = lamaSewa.ToString();

            // Hitung total biaya (Lama Sewa x Harga Mobil per Hari)
            decimal totalBiaya = lamaSewa * hargaMobilTerpilih;
            txt_total.Text = totalBiaya.ToString();
        }

        // EVENT: Ketika tanggal sewa diubah oleh user
        private void dtp_tgl_sewa_ValueChanged(object sender, EventArgs e)
        {
            HitungEstimasiBiaya();
        }

        // EVENT: Ketika tanggal kembali diubah oleh user
        private void dtp_tgl_kembali_ValueChanged(object sender, EventArgs e)
        {
            HitungEstimasiBiaya();
        }

        // EVENT: Ketika pilihan mobil diganti (untuk mengambil harga_sewa mobil tersebut)
        private void cmb_mobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_mobil.SelectedIndex != -1 && cmb_mobil.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cmb_mobil.SelectedItem;
                hargaMobilTerpilih = Convert.ToDecimal(row["harga_sewa"]);

                // Hitung ulang biaya karena harga mobilnya berubah
                HitungEstimasiBiaya();
            }
        }

        // 3. EVENT TOMBOL SIMPAN KLIK
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input wajib
            if (cmb_pelanggan.SelectedIndex == -1 || cmb_mobil.SelectedIndex == -1 || string.IsNullOrEmpty(txt_total.Text))
            {
                MessageBox.Show("Harap lengkapi data Pelanggan, Mobil, dan Tanggal terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime tglSewa = dtp_tgl_sewa.Value;
            DateTime tglKembali = dtp_tgl_kembali.Value;

            if (tglKembali.Date < tglSewa.Date)
            {
                MessageBox.Show("Tanggal kembali tidak boleh lebih awal dari tanggal sewa!", "Validasi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Siapkan data untuk dikirim ke Service
            // Catatan: Untuk idRental "R01" ini dummy, jika Anda punya txtIdRental silakan ganti ke txtIdRental.Text
            string idRental = "R01";
            string idMobil = cmb_mobil.SelectedValue.ToString();
            string idPelanggan = cmb_pelanggan.SelectedValue.ToString();
            decimal totalBiaya = Convert.ToDecimal(txt_total.Text);

            // Panggil fungsi simpan yang ada di transaksirental_serve
            bool apakahSukses = sewaService.SimpanTransaksiSewa(idRental, idMobil, idPelanggan, tglSewa, tglKembali, totalBiaya);

            if (apakahSukses)
            {
                MessageBox.Show("Transaksi Rental berhasil disimpan! Status mobil otomatis berubah menjadi 'Disewa'.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshHalaman(); // Segarkan isi tabel dan kosongkan form
            }
            else
            {
                MessageBox.Show("Gagal menyimpan transaksi! Periksa kembali koneksi atau data database Anda.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. EVENT TOMBOL BATAL KLIK
        private void btnBatal_Click(object sender, EventArgs e)
        {
            RefreshHalaman();
        }
    }
}