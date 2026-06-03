namespace siremob.view
{
    partial class PengembalianPembayaran
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.txt_total_bayar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_tgl_kembali_aktual = new System.Windows.Forms.DateTimePicker();
            this.txt_denda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_biaya_sewa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_tgl_sewa = new System.Windows.Forms.DateTimePicker();
            this.txt_nama_pelanggan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_tgl_kembali_rencana = new System.Windows.Forms.DateTimePicker();
            this.txt_id_rental = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_pengembalian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.dgv_pengembalian = new System.Windows.Forms.DataGridView();
            this.id_pengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_kembali_rencana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_kembali_aktual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_bayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_pengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_ststus_pengembalian = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1939, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(248)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengembalian dan Pembayaran";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(118)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.cmb_ststus_pengembalian);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btn_batal);
            this.panel2.Controls.Add(this.btn_hapus);
            this.panel2.Controls.Add(this.btn_ubah);
            this.panel2.Controls.Add(this.btn_simpan);
            this.panel2.Controls.Add(this.txt_total_bayar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtp_tgl_kembali_aktual);
            this.panel2.Controls.Add(this.txt_denda);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_biaya_sewa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtp_tgl_sewa);
            this.panel2.Controls.Add(this.txt_nama_pelanggan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtp_tgl_kembali_rencana);
            this.panel2.Controls.Add(this.txt_id_rental);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_id_pengembalian);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 1080);
            this.panel2.TabIndex = 2;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(28, 823);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(91, 45);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "TAMBAH";
            this.btn_simpan.UseVisualStyleBackColor = false;
            // 
            // txt_total_bayar
            // 
            this.txt_total_bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_bayar.Location = new System.Drawing.Point(30, 683);
            this.txt_total_bayar.Name = "txt_total_bayar";
            this.txt_total_bayar.Size = new System.Drawing.Size(401, 30);
            this.txt_total_bayar.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 655);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total Bayar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tanggal Kembali Aktual";
            // 
            // dtp_tgl_kembali_aktual
            // 
            this.dtp_tgl_kembali_aktual.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgl_kembali_aktual.Location = new System.Drawing.Point(32, 440);
            this.dtp_tgl_kembali_aktual.Name = "dtp_tgl_kembali_aktual";
            this.dtp_tgl_kembali_aktual.Size = new System.Drawing.Size(399, 26);
            this.dtp_tgl_kembali_aktual.TabIndex = 13;
            // 
            // txt_denda
            // 
            this.txt_denda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_denda.Location = new System.Drawing.Point(32, 597);
            this.txt_denda.Name = "txt_denda";
            this.txt_denda.Size = new System.Drawing.Size(401, 30);
            this.txt_denda.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Denda";
            // 
            // txt_biaya_sewa
            // 
            this.txt_biaya_sewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_biaya_sewa.Location = new System.Drawing.Point(32, 518);
            this.txt_biaya_sewa.Name = "txt_biaya_sewa";
            this.txt_biaya_sewa.Size = new System.Drawing.Size(401, 30);
            this.txt_biaya_sewa.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Biaya Sewa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Sewa";
            // 
            // dtp_tgl_sewa
            // 
            this.dtp_tgl_sewa.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgl_sewa.Location = new System.Drawing.Point(36, 283);
            this.dtp_tgl_sewa.Name = "dtp_tgl_sewa";
            this.dtp_tgl_sewa.Size = new System.Drawing.Size(399, 26);
            this.dtp_tgl_sewa.TabIndex = 7;
            // 
            // txt_nama_pelanggan
            // 
            this.txt_nama_pelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_pelanggan.Location = new System.Drawing.Point(37, 203);
            this.txt_nama_pelanggan.Name = "txt_nama_pelanggan";
            this.txt_nama_pelanggan.Size = new System.Drawing.Size(401, 30);
            this.txt_nama_pelanggan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal Kembali Rencana";
            // 
            // dtp_tgl_kembali_rencana
            // 
            this.dtp_tgl_kembali_rencana.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tgl_kembali_rencana.Location = new System.Drawing.Point(34, 360);
            this.dtp_tgl_kembali_rencana.Name = "dtp_tgl_kembali_rencana";
            this.dtp_tgl_kembali_rencana.Size = new System.Drawing.Size(399, 26);
            this.dtp_tgl_kembali_rencana.TabIndex = 3;
            // 
            // txt_id_rental
            // 
            this.txt_id_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_rental.Location = new System.Drawing.Point(36, 121);
            this.txt_id_rental.Name = "txt_id_rental";
            this.txt_id_rental.Size = new System.Drawing.Size(401, 30);
            this.txt_id_rental.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Rental";
            // 
            // txt_id_pengembalian
            // 
            this.txt_id_pengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_pengembalian.Location = new System.Drawing.Point(36, 46);
            this.txt_id_pengembalian.Name = "txt_id_pengembalian";
            this.txt_id_pengembalian.Size = new System.Drawing.Size(400, 30);
            this.txt_id_pengembalian.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Pengembalian";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.panel3.Controls.Add(this.dgv_pengembalian);
            this.panel3.Controls.Add(this.btn_cari);
            this.panel3.Controls.Add(this.txt_cari);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(472, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1471, 998);
            this.panel3.TabIndex = 3;
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.ForeColor = System.Drawing.Color.White;
            this.btn_ubah.Location = new System.Drawing.Point(132, 823);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(91, 45);
            this.btn_ubah.TabIndex = 17;
            this.btn_ubah.Text = "UBAH";
            this.btn_ubah.UseVisualStyleBackColor = false;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(235, 823);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(91, 45);
            this.btn_hapus.TabIndex = 18;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = false;
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btn_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(338, 823);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(91, 45);
            this.btn_batal.TabIndex = 19;
            this.btn_batal.Text = "BATAL";
            this.btn_batal.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cari:";
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(96, 27);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(400, 30);
            this.txt_cari.TabIndex = 20;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.btn_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.Color.White;
            this.btn_cari.Location = new System.Drawing.Point(515, 25);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(66, 34);
            this.btn_cari.TabIndex = 20;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = false;
            // 
            // dgv_pengembalian
            // 
            this.dgv_pengembalian.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pengembalian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pengembalian,
            this.id_rental,
            this.nama_pelanggan,
            this.tgl_sewa,
            this.tgl_kembali_rencana,
            this.tgl_kembali_aktual,
            this.denda,
            this.total_bayar,
            this.status_pengembalian});
            this.dgv_pengembalian.Location = new System.Drawing.Point(35, 83);
            this.dgv_pengembalian.Name = "dgv_pengembalian";
            this.dgv_pengembalian.RowHeadersWidth = 62;
            this.dgv_pengembalian.RowTemplate.Height = 28;
            this.dgv_pengembalian.Size = new System.Drawing.Size(1112, 713);
            this.dgv_pengembalian.TabIndex = 21;
            this.dgv_pengembalian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_pengembalian
            // 
            this.id_pengembalian.HeaderText = "ID Pengembalian";
            this.id_pengembalian.MinimumWidth = 8;
            this.id_pengembalian.Name = "id_pengembalian";
            this.id_pengembalian.Width = 150;
            // 
            // id_rental
            // 
            this.id_rental.HeaderText = "ID Rental";
            this.id_rental.MinimumWidth = 8;
            this.id_rental.Name = "id_rental";
            // 
            // nama_pelanggan
            // 
            this.nama_pelanggan.HeaderText = "Nama Pelanggan";
            this.nama_pelanggan.MinimumWidth = 8;
            this.nama_pelanggan.Name = "nama_pelanggan";
            // 
            // tgl_sewa
            // 
            this.tgl_sewa.HeaderText = "Tanggal Sewa";
            this.tgl_sewa.MinimumWidth = 8;
            this.tgl_sewa.Name = "tgl_sewa";
            // 
            // tgl_kembali_rencana
            // 
            this.tgl_kembali_rencana.HeaderText = "Tanggal Kembali Rencana";
            this.tgl_kembali_rencana.MinimumWidth = 8;
            this.tgl_kembali_rencana.Name = "tgl_kembali_rencana";
            this.tgl_kembali_rencana.Width = 150;
            // 
            // tgl_kembali_aktual
            // 
            this.tgl_kembali_aktual.HeaderText = "Tanggal Kembali Aktual";
            this.tgl_kembali_aktual.MinimumWidth = 8;
            this.tgl_kembali_aktual.Name = "tgl_kembali_aktual";
            // 
            // denda
            // 
            this.denda.HeaderText = "Denda";
            this.denda.MinimumWidth = 8;
            this.denda.Name = "denda";
            // 
            // total_bayar
            // 
            this.total_bayar.HeaderText = "Total Bayar";
            this.total_bayar.MinimumWidth = 8;
            this.total_bayar.Name = "total_bayar";
            // 
            // status_pengembalian
            // 
            this.status_pengembalian.HeaderText = "Status Pengembalian";
            this.status_pengembalian.MinimumWidth = 8;
            this.status_pengembalian.Name = "status_pengembalian";
            this.status_pengembalian.Width = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 740);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Status Pembayaran";
            // 
            // cmb_ststus_pengembalian
            // 
            this.cmb_ststus_pengembalian.FormattingEnabled = true;
            this.cmb_ststus_pengembalian.Location = new System.Drawing.Point(28, 768);
            this.cmb_ststus_pengembalian.Name = "cmb_ststus_pengembalian";
            this.cmb_ststus_pengembalian.Size = new System.Drawing.Size(405, 28);
            this.cmb_ststus_pengembalian.TabIndex = 22;
            // 
            // PengembalianPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 974);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PengembalianPembayaran";
            this.Text = "PengembalianPembayaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pengembalian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_id_pengembalian;
        private System.Windows.Forms.TextBox txt_id_rental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_tgl_kembali_rencana;
        private System.Windows.Forms.TextBox txt_nama_pelanggan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_tgl_sewa;
        private System.Windows.Forms.TextBox txt_biaya_sewa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_denda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_tgl_kembali_aktual;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox txt_total_bayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_pengembalian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_kembali_rencana;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_kembali_aktual;
        private System.Windows.Forms.DataGridViewTextBoxColumn denda;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_bayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_pengembalian;
        private System.Windows.Forms.ComboBox cmb_ststus_pengembalian;
    }
}