namespace siremob.view
{
    partial class financial_reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.lblDari = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.colIdPengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDendaKeterlambatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDendaKerusakan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardRentalPanel = new System.Windows.Forms.Panel();
            this.lblRentalTotal = new System.Windows.Forms.Label();
            this.lblRentalTitle = new System.Windows.Forms.Label();
            this.cardDendaKeterlambatanPanel = new System.Windows.Forms.Panel();
            this.lblDendaKeterlambatanTotal = new System.Windows.Forms.Label();
            this.lblDendaKeterlambatanTitle = new System.Windows.Forms.Label();
            this.cardDendaKerusakanPanel = new System.Windows.Forms.Panel();
            this.lblDendaKerusakanTotal = new System.Windows.Forms.Label();
            this.lblDendaKerusakanTitle = new System.Windows.Forms.Label();
            this.cardOmzetPanel = new System.Windows.Forms.Panel();
            this.lblOmzetTotal = new System.Windows.Forms.Label();
            this.lblOmzetTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.cardRentalPanel.SuspendLayout();
            this.cardDendaKeterlambatanPanel.SuspendLayout();
            this.cardDendaKerusakanPanel.SuspendLayout();
            this.cardOmzetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Laporan Keuangan";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.btnReset);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.dtpSampai);
            this.panelFilter.Controls.Add(this.lblSampai);
            this.panelFilter.Controls.Add(this.dtpDari);
            this.panelFilter.Controls.Add(this.lblDari);
            this.panelFilter.Location = new System.Drawing.Point(34, 312);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1282, 87);
            this.panelFilter.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1108, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFilter.Location = new System.Drawing.Point(951, 15);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(135, 50);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Terapkan";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // dtpSampai
            // 
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSampai.Location = new System.Drawing.Point(562, 22);
            this.dtpSampai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(337, 34);
            this.dtpSampai.TabIndex = 3;
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblSampai.Location = new System.Drawing.Point(472, 28);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(78, 28);
            this.lblSampai.TabIndex = 2;
            this.lblSampai.Text = "Sampai";
            // 
            // dtpDari
            // 
            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDari.Location = new System.Drawing.Point(101, 22);
            this.dtpDari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.Size = new System.Drawing.Size(337, 34);
            this.dtpDari.TabIndex = 1;
            // 
            // lblDari
            // 
            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblDari.Location = new System.Drawing.Point(22, 28);
            this.lblDari.Name = "lblDari";
            this.lblDari.Size = new System.Drawing.Size(48, 28);
            this.lblDari.TabIndex = 0;
            this.lblDari.Text = "Dari";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPengembalian,
            this.colIdRental,
            this.colPelanggan,
            this.colMobil,
            this.colTanggal,
            this.colRentalFee,
            this.colDendaKeterlambatan,
            this.colDendaKerusakan,
            this.colTotalBayar});
            this.dgvLaporan.Location = new System.Drawing.Point(34, 425);
            this.dgvLaporan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(1282, 438);
            this.dgvLaporan.TabIndex = 6;
            // 
            // colIdPengembalian
            // 
            this.colIdPengembalian.HeaderText = "ID Kembali";
            this.colIdPengembalian.MinimumWidth = 6;
            this.colIdPengembalian.Name = "colIdPengembalian";
            this.colIdPengembalian.ReadOnly = true;
            // 
            // colIdRental
            // 
            this.colIdRental.HeaderText = "ID Rental";
            this.colIdRental.MinimumWidth = 6;
            this.colIdRental.Name = "colIdRental";
            this.colIdRental.ReadOnly = true;
            // 
            // colPelanggan
            // 
            this.colPelanggan.HeaderText = "Nama Pelanggan";
            this.colPelanggan.MinimumWidth = 6;
            this.colPelanggan.Name = "colPelanggan";
            this.colPelanggan.ReadOnly = true;
            // 
            // colMobil
            // 
            this.colMobil.HeaderText = "Mobil";
            this.colMobil.MinimumWidth = 6;
            this.colMobil.Name = "colMobil";
            this.colMobil.ReadOnly = true;
            // 
            // colTanggal
            // 
            this.colTanggal.HeaderText = "Tanggal Kembali";
            this.colTanggal.MinimumWidth = 6;
            this.colTanggal.Name = "colTanggal";
            this.colTanggal.ReadOnly = true;
            // 
            // colRentalFee
            // 
            this.colRentalFee.HeaderText = "Tarif Sewa";
            this.colRentalFee.MinimumWidth = 6;
            this.colRentalFee.Name = "colRentalFee";
            this.colRentalFee.ReadOnly = true;
            // 
            // colDendaKeterlambatan
            // 
            this.colDendaKeterlambatan.HeaderText = "Denda Telat";
            this.colDendaKeterlambatan.MinimumWidth = 6;
            this.colDendaKeterlambatan.Name = "colDendaKeterlambatan";
            this.colDendaKeterlambatan.ReadOnly = true;
            // 
            // colDendaKerusakan
            // 
            this.colDendaKerusakan.HeaderText = "Denda Kerusakan";
            this.colDendaKerusakan.MinimumWidth = 6;
            this.colDendaKerusakan.Name = "colDendaKerusakan";
            this.colDendaKerusakan.ReadOnly = true;
            // 
            // colTotalBayar
            // 
            this.colTotalBayar.HeaderText = "Total Bayar";
            this.colTotalBayar.MinimumWidth = 6;
            this.colTotalBayar.Name = "colTotalBayar";
            this.colTotalBayar.ReadOnly = true;
            // 
            // cardRentalPanel
            // 
            this.cardRentalPanel.BackColor = System.Drawing.Color.White;
            this.cardRentalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardRentalPanel.Controls.Add(this.lblRentalTotal);
            this.cardRentalPanel.Controls.Add(this.lblRentalTitle);
            this.cardRentalPanel.Location = new System.Drawing.Point(34, 125);
            this.cardRentalPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardRentalPanel.Name = "cardRentalPanel";
            this.cardRentalPanel.Size = new System.Drawing.Size(292, 150);
            this.cardRentalPanel.TabIndex = 1;
            // 
            // lblRentalTotal
            // 
            this.lblRentalTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblRentalTotal.Location = new System.Drawing.Point(11, 62);
            this.lblRentalTotal.Name = "lblRentalTotal";
            this.lblRentalTotal.Size = new System.Drawing.Size(270, 50);
            this.lblRentalTotal.TabIndex = 1;
            this.lblRentalTotal.Text = "Rp 0";
            this.lblRentalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRentalTitle
            // 
            this.lblRentalTitle.AutoSize = true;
            this.lblRentalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRentalTitle.Location = new System.Drawing.Point(11, 19);
            this.lblRentalTitle.Name = "lblRentalTitle";
            this.lblRentalTitle.Size = new System.Drawing.Size(177, 28);
            this.lblRentalTitle.TabIndex = 0;
            this.lblRentalTitle.Text = "Keuntungan Sewa";
            // 
            // cardDendaKeterlambatanPanel
            // 
            this.cardDendaKeterlambatanPanel.BackColor = System.Drawing.Color.White;
            this.cardDendaKeterlambatanPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDendaKeterlambatanPanel.Controls.Add(this.lblDendaKeterlambatanTotal);
            this.cardDendaKeterlambatanPanel.Controls.Add(this.lblDendaKeterlambatanTitle);
            this.cardDendaKeterlambatanPanel.Location = new System.Drawing.Point(360, 125);
            this.cardDendaKeterlambatanPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardDendaKeterlambatanPanel.Name = "cardDendaKeterlambatanPanel";
            this.cardDendaKeterlambatanPanel.Size = new System.Drawing.Size(292, 150);
            this.cardDendaKeterlambatanPanel.TabIndex = 2;
            // 
            // lblDendaKeterlambatanTotal
            // 
            this.lblDendaKeterlambatanTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaKeterlambatanTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblDendaKeterlambatanTotal.Location = new System.Drawing.Point(11, 62);
            this.lblDendaKeterlambatanTotal.Name = "lblDendaKeterlambatanTotal";
            this.lblDendaKeterlambatanTotal.Size = new System.Drawing.Size(270, 50);
            this.lblDendaKeterlambatanTotal.TabIndex = 1;
            this.lblDendaKeterlambatanTotal.Text = "Rp 0";
            this.lblDendaKeterlambatanTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDendaKeterlambatanTitle
            // 
            this.lblDendaKeterlambatanTitle.AutoSize = true;
            this.lblDendaKeterlambatanTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaKeterlambatanTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDendaKeterlambatanTitle.Location = new System.Drawing.Point(11, 19);
            this.lblDendaKeterlambatanTitle.Name = "lblDendaKeterlambatanTitle";
            this.lblDendaKeterlambatanTitle.Size = new System.Drawing.Size(204, 28);
            this.lblDendaKeterlambatanTitle.TabIndex = 0;
            this.lblDendaKeterlambatanTitle.Text = "Pendapatan Denda T.";
            // 
            // cardDendaKerusakanPanel
            // 
            this.cardDendaKerusakanPanel.BackColor = System.Drawing.Color.White;
            this.cardDendaKerusakanPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDendaKerusakanPanel.Controls.Add(this.lblDendaKerusakanTotal);
            this.cardDendaKerusakanPanel.Controls.Add(this.lblDendaKerusakanTitle);
            this.cardDendaKerusakanPanel.Location = new System.Drawing.Point(686, 125);
            this.cardDendaKerusakanPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardDendaKerusakanPanel.Name = "cardDendaKerusakanPanel";
            this.cardDendaKerusakanPanel.Size = new System.Drawing.Size(292, 150);
            this.cardDendaKerusakanPanel.TabIndex = 3;
            // 
            // lblDendaKerusakanTotal
            // 
            this.lblDendaKerusakanTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaKerusakanTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblDendaKerusakanTotal.Location = new System.Drawing.Point(11, 62);
            this.lblDendaKerusakanTotal.Name = "lblDendaKerusakanTotal";
            this.lblDendaKerusakanTotal.Size = new System.Drawing.Size(270, 50);
            this.lblDendaKerusakanTotal.TabIndex = 1;
            this.lblDendaKerusakanTotal.Text = "Rp 0";
            this.lblDendaKerusakanTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDendaKerusakanTitle
            // 
            this.lblDendaKerusakanTitle.AutoSize = true;
            this.lblDendaKerusakanTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaKerusakanTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDendaKerusakanTitle.Location = new System.Drawing.Point(11, 19);
            this.lblDendaKerusakanTitle.Name = "lblDendaKerusakanTitle";
            this.lblDendaKerusakanTitle.Size = new System.Drawing.Size(207, 28);
            this.lblDendaKerusakanTitle.TabIndex = 0;
            this.lblDendaKerusakanTitle.Text = "Pendapatan Denda K.";
            // 
            // cardOmzetPanel
            // 
            this.cardOmzetPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cardOmzetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardOmzetPanel.Controls.Add(this.lblOmzetTotal);
            this.cardOmzetPanel.Controls.Add(this.lblOmzetTitle);
            this.cardOmzetPanel.Location = new System.Drawing.Point(1012, 125);
            this.cardOmzetPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardOmzetPanel.Name = "cardOmzetPanel";
            this.cardOmzetPanel.Size = new System.Drawing.Size(304, 150);
            this.cardOmzetPanel.TabIndex = 4;
            // 
            // lblOmzetTotal
            // 
            this.lblOmzetTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmzetTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.lblOmzetTotal.Location = new System.Drawing.Point(11, 62);
            this.lblOmzetTotal.Name = "lblOmzetTotal";
            this.lblOmzetTotal.Size = new System.Drawing.Size(281, 50);
            this.lblOmzetTotal.TabIndex = 1;
            this.lblOmzetTotal.Text = "Rp 0";
            this.lblOmzetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOmzetTitle
            // 
            this.lblOmzetTitle.AutoSize = true;
            this.lblOmzetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmzetTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblOmzetTitle.Location = new System.Drawing.Point(11, 19);
            this.lblOmzetTitle.Name = "lblOmzetTitle";
            this.lblOmzetTitle.Size = new System.Drawing.Size(181, 28);
            this.lblOmzetTitle.TabIndex = 0;
            this.lblOmzetTitle.Text = "Total Omzet (Nett)";
            // 
            // financial_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1350, 900);
            this.Controls.Add(this.cardOmzetPanel);
            this.Controls.Add(this.cardDendaKerusakanPanel);
            this.Controls.Add(this.cardDendaKeterlambatanPanel);
            this.Controls.Add(this.cardRentalPanel);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "financial_reports";
            this.Text = "financial_reports";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.cardRentalPanel.ResumeLayout(false);
            this.cardRentalPanel.PerformLayout();
            this.cardDendaKeterlambatanPanel.ResumeLayout(false);
            this.cardDendaKeterlambatanPanel.PerformLayout();
            this.cardDendaKerusakanPanel.ResumeLayout(false);
            this.cardDendaKerusakanPanel.PerformLayout();
            this.cardOmzetPanel.ResumeLayout(false);
            this.cardOmzetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Panel cardRentalPanel;
        private System.Windows.Forms.Label lblRentalTotal;
        private System.Windows.Forms.Label lblRentalTitle;
        private System.Windows.Forms.Panel cardDendaKeterlambatanPanel;
        private System.Windows.Forms.Label lblDendaKeterlambatanTotal;
        private System.Windows.Forms.Label lblDendaKeterlambatanTitle;
        private System.Windows.Forms.Panel cardDendaKerusakanPanel;
        private System.Windows.Forms.Label lblDendaKerusakanTotal;
        private System.Windows.Forms.Label lblDendaKerusakanTitle;
        private System.Windows.Forms.Panel cardOmzetPanel;
        private System.Windows.Forms.Label lblOmzetTotal;
        private System.Windows.Forms.Label lblOmzetTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRental;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRentalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDendaKeterlambatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDendaKerusakan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBayar;
    }
}
