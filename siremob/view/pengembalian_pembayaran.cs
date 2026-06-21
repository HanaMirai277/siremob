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
using siremob.konfigurasi;
using siremob.service;
using System.Drawing.Text;

namespace siremob.view
{
    public partial class pengembalian_pembayaran : Form
    {
        private pengembalian_pembayaran_serve pengembalianService = new pengembalian_pembayaran_serve();

        // Variabel bantuan untuk menyimpan data sementara
        private DateTime tanggalKembaliRencana;
        private decimal hargaSewaPerHari = 0;
        private string idMobilSewa = "";
        //private dynamic koneksi;

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
            ResetForm();
        }

        private void ResetForm()
        {
            // Ambil ID otomatis lalu tampil di TextBox ID Pengembalian
            txt_idpengembalian.Text = pengembalianService.BuatIdOtomatis();
            txt_idpengembalian.ReadOnly = true; // Kunci agar tidak bisa diubah kasir

            // Kosongkan kontrol lainnya
            cmb_idrental.SelectedIndex = -1;
            dtp_tgl_kembaliaktual.Value = DateTime.Now;

            txt_nama_pelanggan.Text = "";
            txt_nama_pelanggan.ReadOnly = true; // Kunci agar tidak bisa diubah kasir

            txt_platnomor.Text = "";
            txt_platnomor.ReadOnly = true;

            txt_merk.Text = "";
            txt_merk.ReadOnly = true;

            txt_tipe.Text = "";
            txt_tipe.ReadOnly = true;

            cmb_jaminan.SelectedIndex = -1;

            txt_biayarental.Text = "0";
            txt_biayarental.ReadOnly = true;

            txt_keterlambatan_hari.Text = "0";
            txt_keterlambatan_hari.ReadOnly = true;

            txt_denda_keterlambatan.Text = "0";
            txt_denda_keterlambatan.ReadOnly = true;

            txt_denda_kerusakan.Text = "0";
            txt_denda_kerusakan.ReadOnly = true; // Default awal terkunci sebelum kondisi dipilih

            txt_total_bayar.Text = "0";
            txt_total_bayar.ReadOnly = true;

            // Isi opsi kondisi mobil
            cmb_kondisimobil.Items.Clear(); // Bersihkan dulu agar tidak duplikat
            cmb_kondisimobil.Items.Add("Baik");
            cmb_kondisimobil.Items.Add("Lecet Ringan");
            cmb_kondisimobil.Items.Add("Rusak Ringan");
            cmb_kondisimobil.Items.Add("Rusak Berat");
            cmb_kondisimobil.SelectedIndex = -1;

            // Isi opsi status pembayaran
            cmb_ststus_pembayaran.Items.Clear(); // Bersihkan dulu agar tidak duplikat
            cmb_ststus_pembayaran.Items.Add("Lunas");
            cmb_ststus_pembayaran.Items.Add("Belum Lunas");
            cmb_ststus_pembayaran.SelectedIndex = -1;

            // Isi opsi ID Rental langsung dari database
            cmb_idrental.Items.Clear();
            List<string> listRental = pengembalianService.AmbilSemuaIdRentalBerjalan();
            foreach (string id in listRental)
            {
                cmb_idrental.Items.Add(id);
            }

            // Segarkan DataGridView (dgv_pengembalian)
            dgv_pengembalian.DataSource = pengembalianService.TampilkanSemuaPengembalian();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            // VALIDASI 1: Pastikan ID Rental sudah dipilih
            if (cmb_idrental.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih ID Rental terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDASI 2: Logika Kondisi Mobil vs Kolom Denda 
            decimal.TryParse(txt_denda_kerusakan.Text.Replace(".", "").Replace(",", ""), out decimal dendaRusak);
            if ((cmb_kondisimobil.Text == "Lecet Ringan" || cmb_kondisimobil.Text == "Rusak Ringan" || cmb_kondisimobil.Text == "Rusak Berat") && dendaRusak == 0)
            {
                MessageBox.Show("Kondisi mobil rusak/lecet, harap masukkan nominal denda kerusakan terlebih dahulu!",
                                "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDASI 3: Pastikan Status Pembayaran dipilih
            if (cmb_ststus_pembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan tentukan Status Pembayaran (Lunas/Belum Lunas)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mengisi data ke model berdasarkan inputan dari form
            pengembalian_pembayaran_model pm = new pengembalian_pembayaran_model();
            pm.IdPengembalian = txt_idpengembalian.Text;
            pm.IdRental = cmb_idrental.SelectedItem.ToString();
            pm.TglKembaliAktual = dtp_tgl_kembaliaktual.Value;
            pm.KondisiMobil = cmb_kondisimobil.Text;
            pm.KeterlambatanHari = Convert.ToInt32(txt_keterlambatan_hari.Text);

            decimal.TryParse(txt_denda_keterlambatan.Text.Replace(".", "").Replace(",", ""), out decimal dendaTelat);
            pm.DendaKeterlambatan = dendaTelat;
            pm.DendaKerusakan = dendaRusak;

            decimal.TryParse(txt_total_bayar.Text.Replace(".", "").Replace(",", ""), out decimal totalBayar);
            pm.TotalBayar = totalBayar;
            pm.StatusPembayaran = cmb_ststus_pembayaran.Text;

            // Mengambil ID Mobil dari database berdasarkan ID Rental yang dipilih untuk disimpan di tabel pengembalian
            bool sukses = pengembalianService.SimpanTransaksiPengembalian(pm, idMobilSewa);

            if (sukses)
            {
                // MESSAGE BOX SUKSES TERAKHIR
                MessageBox.Show($"Pembayaran Berhasil! Total diterima: Rp {pm.TotalBayar:N0}.\n\n" +
                                $"Silakan kembalikan jaminan [{cmb_jaminan.Text}] kepada pelanggan.",
                                "Sukses Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm(); // Segarkan kembali form dan DataGridView
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data pengembalian transaksi.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin membatalkan transaksi ini? Semua data yang diinput akan dibersihkan.",
                                          "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void cmb_kondisimobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kondisimobil.Text == "Baik")
            {
                txt_denda_kerusakan.Text = "0";
                txt_denda_kerusakan.ReadOnly = true; // Kunci total jika mobil aman
            }
            else if (cmb_kondisimobil.Text == "Lecet Ringan")
            {
                txt_denda_kerusakan.Text = "200000";
                txt_denda_kerusakan.ReadOnly = false; // Buka agar kasir bisa menyesuaikan jika ada perubahan tarif bengkel
            }
            else if (cmb_kondisimobil.Text == "Rusak Ringan")
            {
                txt_denda_kerusakan.Text = "750000";
                txt_denda_kerusakan.ReadOnly = false;
            }
            else if (cmb_kondisimobil.Text == "Rusak Berat")
            {
                txt_denda_kerusakan.Text = "3000000";
                txt_denda_kerusakan.ReadOnly = false;
            }
            HitungKeterlambatanDanDenda();
        }

        private void cmb_ststus_pengembalian_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_idrental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_idrental.SelectedIndex != -1 && cmb_idrental.SelectedItem != null)
            {
                string idRentalTerpilih = cmb_idrental.SelectedItem.ToString();

                // Panggil service untuk mengambil data dari database
                DataTable dtDetail = pengembalianService.AmbilDetailRental(idRentalTerpilih);

                if (dtDetail.Rows.Count > 0)
                {
                    DataRow row = dtDetail.Rows[0];

                    // Isi semua komponen di Form pengembalian dan pembayaran secara otomatis
                    idMobilSewa = row["id_mobil"].ToString();
                    txt_nama_pelanggan.Text = row["nama_pelanggan"].ToString();
                    txt_platnomor.Text = row["platnomor"].ToString();
                    txt_merk.Text = row["merk"].ToString();
                    txt_tipe.Text = row["tipe"].ToString();
                    cmb_jaminan.Text = row["jaminan"].ToString();
                    txt_biayarental.Text = Convert.ToDecimal(row["totalbiaya_estimasi"]).ToString("N0");

                    // Simpan data ke variabel bantuan untuk kalkulasi denda
                    tanggalKembaliRencana = Convert.ToDateTime(row["tanggalkembali_rencana"]);
                    hargaSewaPerHari = Convert.ToDecimal(row["hargasewaperhari"]);

                    // Message Box Jaminan 
                    MessageBox.Show($"Mobil ditemukan!\nPelanggan ini menjaminkan: [{cmb_jaminan.Text}].\n\n" +
                                    $"Pastikan barang jaminan ada di tangan Anda sebelum melanjutkan.",
                                    "Informasi Jaminan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hitung ulang hari keterlambatan
                    HitungKeterlambatanDanDenda();
                }
            }
        }

        private void HitungKeterlambatanDanDenda()
        {
            // Jika belum memilih ID Rental, hentikan perhitungan
            if (cmb_idrental.SelectedIndex == -1) return;

            // 1. Hitung Selisih Hari (Tanggal Aktual Kembali - Tanggal Rencana Kembali)
            DateTime tglAktual = dtp_tgl_kembaliaktual.Value.Date;
            DateTime tglRencana = tanggalKembaliRencana.Date;

            TimeSpan selisih = tglAktual - tglRencana;
            int hariTelat = selisih.Days;

            if (hariTelat < 0)
            {
                hariTelat = 0;
            }
            txt_keterlambatan_hari.Text = hariTelat.ToString();

            // 2. Hitung Denda Keterlambatan (Harga Sewa Mobil Per Hari x Jumlah Hari Telat)
            decimal dendaTelat = hargaSewaPerHari * hariTelat;
            txt_denda_keterlambatan.Text = dendaTelat.ToString("N0");

            // 3. Ambil Nilai Denda Kerusakan yang tertera di form
            decimal dendaRusak = 0;
            if (!string.IsNullOrEmpty(txt_denda_kerusakan.Text))
            {
                string cleanDendaRusak = txt_denda_kerusakan.Text.Replace(".", "").Replace(",", "");
                decimal.TryParse(cleanDendaRusak, out dendaRusak);
            }

            // 4. Ambil Nilai Total Biaya Sewa Estimasi / Biaya Rental Utama dari database yang tampil di form
            decimal biayaRentalAwal = 0;
            if (!string.IsNullOrEmpty(txt_biayarental.Text))
            {
                string cleanBiayaRental = txt_biayarental.Text.Replace(".", "").Replace(",", "");
                decimal.TryParse(cleanBiayaRental, out biayaRentalAwal);
            }

            // 5. Hitung Total Bayar Keseluruhan (Biaya Sewa + Denda Keterlambatan + Denda Kerusakan)
            decimal totalBayarKeseluruhan = biayaRentalAwal + dendaTelat + dendaRusak;
            txt_total_bayar.Text = totalBayarKeseluruhan.ToString("N0");
        }

        private void dtp_tgl_kembaliaktual_ValueChanged(object sender, EventArgs e)
        {
            HitungKeterlambatanDanDenda();
        }

        private void txt_denda_kerusakan_TextChanged(object sender, EventArgs e)
        {
            HitungKeterlambatanDanDenda();
        }

        private void txt_denda_keterlambatan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
