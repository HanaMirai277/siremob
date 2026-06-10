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

namespace siremob.view
{
    public partial class financial_reports : Form
    {
        private Koneksi koneksiDb = new Koneksi();

        public financial_reports()
        {
            InitializeComponent();
            
            // Wire up events
            this.Load += new EventHandler(financial_reports_Load);
            btnFilter.Click += new EventHandler(btnFilter_Click);
            btnReset.Click += new EventHandler(btnReset_Click);
        }

        private void financial_reports_Load(object sender, EventArgs e)
        {
            dtpDari.Value = DateTime.Now.AddDays(-30);
            dtpSampai.Value = DateTime.Now;
            TampilkanDataLaporan();
        }

        private void TampilkanDataLaporan(string queryFilter = "")
        {
            try
            {
                dgvLaporan.AutoGenerateColumns = false;
                dgvLaporan.Columns["colIdPengembalian"].DataPropertyName = "id_pengembalian";
                dgvLaporan.Columns["colIdRental"].DataPropertyName = "id_rental";
                dgvLaporan.Columns["colPelanggan"].DataPropertyName = "nama_pelanggan";
                dgvLaporan.Columns["colMobil"].DataPropertyName = "merk";
                dgvLaporan.Columns["colTanggal"].DataPropertyName = "tanggalkembali_aktual";
                dgvLaporan.Columns["colRentalFee"].DataPropertyName = "totalbiaya_estimasi";
                dgvLaporan.Columns["colDendaKeterlambatan"].DataPropertyName = "denda_keterlambatan";
                dgvLaporan.Columns["colDendaKerusakan"].DataPropertyName = "denda_kerusakan";
                dgvLaporan.Columns["colTotalBayar"].DataPropertyName = "total_bayar";

                string query = @"SELECT p.id_pengembalian, p.id_rental, plg.nama AS nama_pelanggan, m.merk, 
                                        p.tanggalkembali_aktual, r.totalbiaya_estimasi, 
                                        p.denda_keterlambatan, p.denda_kerusakan, p.total_bayar
                                 FROM pengembalian p
                                 INNER JOIN rental r ON p.id_rental = r.id_rental
                                 INNER JOIN pelanggan plg ON r.id_pelanggan = plg.id_pelanggan
                                 INNER JOIN mobil m ON r.id_mobil = m.id_mobil";

                if (!string.IsNullOrEmpty(queryFilter))
                {
                    query += " WHERE " + queryFilter;
                }

                query += " ORDER BY p.tanggalkembali_aktual DESC";

                DataTable dt = koneksiDb.EksekusiQuery(query);
                dgvLaporan.DataSource = dt;

                // Calculate KPI Cards
                decimal totalRental = 0;
                decimal totalDendaTelat = 0;
                decimal totalDendaRusak = 0;
                decimal totalOmzet = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalRental += Convert.ToDecimal(row["totalbiaya_estimasi"]);
                    totalDendaTelat += Convert.ToDecimal(row["denda_keterlambatan"]);
                    totalDendaRusak += Convert.ToDecimal(row["denda_kerusakan"]);
                    totalOmzet += Convert.ToDecimal(row["total_bayar"]);
                }

                // Format to Rupiah
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("id-ID");
                lblRentalTotal.Text = totalRental.ToString("C0", culture);
                lblDendaKeterlambatanTotal.Text = totalDendaTelat.ToString("C0", culture);
                lblDendaKerusakanTotal.Text = totalDendaRusak.ToString("C0", culture);
                lblOmzetTotal.Text = totalOmzet.ToString("C0", culture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan keuangan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string sDari = dtpDari.Value.ToString("yyyy-MM-dd");
            string sSampai = dtpSampai.Value.ToString("yyyy-MM-dd");

            string filter = $"p.tanggalkembali_aktual BETWEEN '{sDari}' AND '{sSampai}'";
            TampilkanDataLaporan(filter);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpDari.Value = DateTime.Now.AddDays(-30);
            dtpSampai.Value = DateTime.Now;
            TampilkanDataLaporan();
        }
    }
}
