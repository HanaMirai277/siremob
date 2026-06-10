namespace siremob.view
{
    partial class transaksirental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_tgl_sewa = new System.Windows.Forms.DateTimePicker();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_mobil = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_batal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_lama_sewa = new System.Windows.Forms.TextBox();
            this.cmb_pelanggan = new System.Windows.Forms.ComboBox();
            this.dtp_tgl_kembali = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.colIdMobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatNomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 80);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi Rental ";
            // 
            // dtp_tgl_sewa
            // 
            this.dtp_tgl_sewa.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgl_sewa.Location = new System.Drawing.Point(15, 135);
            this.dtp_tgl_sewa.Name = "dtp_tgl_sewa";
            this.dtp_tgl_sewa.Size = new System.Drawing.Size(315, 26);
            this.dtp_tgl_sewa.TabIndex = 28;
            this.dtp_tgl_sewa.ValueChanged += new System.EventHandler(this.dtp_tgl_sewa_ValueChanged);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_simpan.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(18, 658);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(151, 40);
            this.btn_simpan.TabIndex = 19;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Kembali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal sewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pelanggan\r\n";
            // 
            // cmb_mobil
            // 
            this.cmb_mobil.FormattingEnabled = true;
            this.cmb_mobil.Location = new System.Drawing.Point(15, 85);
            this.cmb_mobil.Name = "cmb_mobil";
            this.cmb_mobil.Size = new System.Drawing.Size(315, 28);
            this.cmb_mobil.TabIndex = 29;
            this.cmb_mobil.SelectedIndexChanged += new System.EventHandler(this.cmb_mobil_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btn_batal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_lama_sewa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_simpan);
            this.panel2.Controls.Add(this.dtp_tgl_sewa);
            this.panel2.Controls.Add(this.cmb_pelanggan);
            this.panel2.Controls.Add(this.cmb_mobil);
            this.panel2.Controls.Add(this.dtp_tgl_kembali);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 725);
            this.panel2.TabIndex = 2;
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_batal.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(175, 658);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(151, 40);
            this.btn_batal.TabIndex = 36;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Biaya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Lama Sewa";
            // 
            // txt_lama_sewa
            // 
            this.txt_lama_sewa.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_lama_sewa.Location = new System.Drawing.Point(15, 225);
            this.txt_lama_sewa.Name = "txt_lama_sewa";
            this.txt_lama_sewa.Size = new System.Drawing.Size(315, 30);
            this.txt_lama_sewa.TabIndex = 32;
            // 
            // cmb_pelanggan
            // 
            this.cmb_pelanggan.FormattingEnabled = true;
            this.cmb_pelanggan.Location = new System.Drawing.Point(15, 37);
            this.cmb_pelanggan.Name = "cmb_pelanggan";
            this.cmb_pelanggan.Size = new System.Drawing.Size(315, 28);
            this.cmb_pelanggan.TabIndex = 30;
            // 
            // dtp_tgl_kembali
            // 
            this.dtp_tgl_kembali.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgl_kembali.Location = new System.Drawing.Point(15, 181);
            this.dtp_tgl_kembali.Name = "dtp_tgl_kembali";
            this.dtp_tgl_kembali.Size = new System.Drawing.Size(315, 26);
            this.dtp_tgl_kembali.TabIndex = 31;
            this.dtp_tgl_kembali.ValueChanged += new System.EventHandler(this.dtp_tgl_kembali_ValueChanged);
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_total.Location = new System.Drawing.Point(15, 271);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(315, 30);
            this.txt_total.TabIndex = 35;
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_transaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMobil,
            this.colPlatNomor,
            this.colMerk,
            this.colTipe,
            this.colTahun,
            this.colWarna,
            this.colHarga});
            this.dgv_transaksi.Location = new System.Drawing.Point(380, 148);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.ReadOnly = true;
            this.dgv_transaksi.RowHeadersWidth = 51;
            this.dgv_transaksi.Size = new System.Drawing.Size(928, 630);
            this.dgv_transaksi.TabIndex = 27;
            // 
            // colIdMobil
            // 
            this.colIdMobil.HeaderText = "No. Nota";
            this.colIdMobil.MinimumWidth = 6;
            this.colIdMobil.Name = "colIdMobil";
            this.colIdMobil.ReadOnly = true;
            this.colIdMobil.Width = 99;
            // 
            // colPlatNomor
            // 
            this.colPlatNomor.HeaderText = "Nama Pelanggan";
            this.colPlatNomor.MinimumWidth = 6;
            this.colPlatNomor.Name = "colPlatNomor";
            this.colPlatNomor.ReadOnly = true;
            this.colPlatNomor.Width = 153;
            // 
            // colMerk
            // 
            this.colMerk.HeaderText = "Mobil";
            this.colMerk.MinimumWidth = 6;
            this.colMerk.Name = "colMerk";
            this.colMerk.ReadOnly = true;
            this.colMerk.Width = 82;
            // 
            // colTipe
            // 
            this.colTipe.HeaderText = "Tanggal Sewa";
            this.colTipe.MinimumWidth = 6;
            this.colTipe.Name = "colTipe";
            this.colTipe.ReadOnly = true;
            this.colTipe.Width = 135;
            // 
            // colTahun
            // 
            this.colTahun.HeaderText = "Tanggal Kembali";
            this.colTahun.MinimumWidth = 6;
            this.colTahun.Name = "colTahun";
            this.colTahun.ReadOnly = true;
            this.colTahun.Width = 149;
            // 
            // colWarna
            // 
            this.colWarna.HeaderText = "Total Biaya";
            this.colWarna.MinimumWidth = 6;
            this.colWarna.Name = "colWarna";
            this.colWarna.ReadOnly = true;
            this.colWarna.Width = 114;
            // 
            // colHarga
            // 
            this.colHarga.HeaderText = "Status transaksi";
            this.colHarga.MinimumWidth = 6;
            this.colHarga.Name = "colHarga";
            this.colHarga.ReadOnly = true;
            this.colHarga.Width = 147;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(398, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cari:";
            // 
            // txb_cari
            // 
            this.txb_cari.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_cari.Location = new System.Drawing.Point(456, 97);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(350, 30);
            this.txb_cari.TabIndex = 29;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.btn_cari.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_cari.ForeColor = System.Drawing.Color.White;
            this.btn_cari.Location = new System.Drawing.Point(825, 94);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 34);
            this.btn_cari.TabIndex = 30;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = false;
            // 
            // transaksirental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1320, 805);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.txb_cari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_transaksi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "transaksirental";
            this.Text = "rental";
            this.Load += new System.EventHandler(this.rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_tgl_sewa;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_mobil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_pelanggan;
        private System.Windows.Forms.DateTimePicker dtp_tgl_kembali;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_lama_sewa;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatNomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
    }
}