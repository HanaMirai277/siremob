namespace siremob.view
{
    partial class mastermobil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_IdMobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_PlatNomor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Tipe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Merk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_Tahun = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_Warna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_Harga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.btn_Hapus = new System.Windows.Forms.Button();
            this.btn_Ubah = new System.Windows.Forms.Button();
            this.btn_Tambah = new System.Windows.Forms.Button();
            this.textBox_Foto = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pbx_Foto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_Cari = new System.Windows.Forms.TextBox();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.dgv_Mobil = new System.Windows.Forms.DataGridView();
            this.colIdMobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatNomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblModeAkses = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tahun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.lblModeAkses);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblModeAkses
            // 
            this.lblModeAkses.AutoSize = true;
            this.lblModeAkses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblModeAkses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeAkses.ForeColor = System.Drawing.Color.White;
            this.lblModeAkses.Location = new System.Drawing.Point(1080, 30);
            this.lblModeAkses.Name = "lblModeAkses";
            this.lblModeAkses.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblModeAkses.Size = new System.Drawing.Size(60, 26);
            this.lblModeAkses.TabIndex = 99;
            this.lblModeAkses.Text = "Mode: Lihat Saja (Read Only)";
            this.lblModeAkses.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Mobil";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbx_IdMobil);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbx_PlatNomor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbx_Tipe);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbx_Merk);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nud_Tahun);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbx_Warna);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbx_Harga);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox_Status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 475);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Mobil";
            // 
            // tbx_IdMobil
            // 
            this.tbx_IdMobil.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_IdMobil.Location = new System.Drawing.Point(15, 39);
            this.tbx_IdMobil.MaxLength = 3;
            this.tbx_IdMobil.Multiline = true;
            this.tbx_IdMobil.Name = "tbx_IdMobil";
            this.tbx_IdMobil.Size = new System.Drawing.Size(315, 35);
            this.tbx_IdMobil.TabIndex = 1;
            this.tbx_IdMobil.TextChanged += new System.EventHandler(this.tbx_IdMobil_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plat Nomor";
            // 
            // tbx_PlatNomor
            // 
            this.tbx_PlatNomor.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_PlatNomor.Location = new System.Drawing.Point(15, 106);
            this.tbx_PlatNomor.Multiline = true;
            this.tbx_PlatNomor.Name = "tbx_PlatNomor";
            this.tbx_PlatNomor.Size = new System.Drawing.Size(315, 35);
            this.tbx_PlatNomor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Merk";
            // 
            // tbx_Tipe
            // 
            this.tbx_Tipe.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_Tipe.Location = new System.Drawing.Point(15, 244);
            this.tbx_Tipe.Multiline = true;
            this.tbx_Tipe.Name = "tbx_Tipe";
            this.tbx_Tipe.Size = new System.Drawing.Size(315, 35);
            this.tbx_Tipe.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipe";
            // 
            // tbx_Merk
            // 
            this.tbx_Merk.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_Merk.Location = new System.Drawing.Point(15, 174);
            this.tbx_Merk.Multiline = true;
            this.tbx_Merk.Name = "tbx_Merk";
            this.tbx_Merk.Size = new System.Drawing.Size(315, 35);
            this.tbx_Merk.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tahun";
            // 
            // nud_Tahun
            // 
            this.nud_Tahun.Font = new System.Drawing.Font("Arial", 10F);
            this.nud_Tahun.Location = new System.Drawing.Point(15, 311);
            this.nud_Tahun.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nud_Tahun.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nud_Tahun.Name = "nud_Tahun";
            this.nud_Tahun.Size = new System.Drawing.Size(89, 27);
            this.nud_Tahun.TabIndex = 9;
            this.nud_Tahun.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Warna";
            // 
            // tbx_Warna
            // 
            this.tbx_Warna.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_Warna.Location = new System.Drawing.Point(15, 367);
            this.tbx_Warna.Multiline = true;
            this.tbx_Warna.Name = "tbx_Warna";
            this.tbx_Warna.Size = new System.Drawing.Size(315, 35);
            this.tbx_Warna.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Harga Sewa Per Hari";
            // 
            // tbx_Harga
            // 
            this.tbx_Harga.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_Harga.Location = new System.Drawing.Point(15, 432);
            this.tbx_Harga.Multiline = true;
            this.tbx_Harga.Name = "tbx_Harga";
            this.tbx_Harga.Size = new System.Drawing.Size(315, 35);
            this.tbx_Harga.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(121, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status Mobil";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.AccessibleName = "nud_statusMobil";
            this.comboBox_Status.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak Tersedia",
            "Dalam Perbaikan"});
            this.comboBox_Status.Location = new System.Drawing.Point(121, 312);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(209, 27);
            this.comboBox_Status.TabIndex = 15;
            this.comboBox_Status.Text = "Tersedia";
            // 
            // btn_Batal
            // 
            this.btn_Batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_Batal.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Batal.ForeColor = System.Drawing.Color.White;
            this.btn_Batal.Location = new System.Drawing.Point(671, 100);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(66, 52);
            this.btn_Batal.TabIndex = 22;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.UseVisualStyleBackColor = false;
            this.btn_Batal.Click += new System.EventHandler(this.button_Batal_Click);
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_Hapus.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Hapus.ForeColor = System.Drawing.Color.White;
            this.btn_Hapus.Location = new System.Drawing.Point(588, 100);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(75, 52);
            this.btn_Hapus.TabIndex = 21;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = false;
            this.btn_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // btn_Ubah
            // 
            this.btn_Ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_Ubah.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Ubah.ForeColor = System.Drawing.Color.White;
            this.btn_Ubah.Location = new System.Drawing.Point(505, 100);
            this.btn_Ubah.Name = "btn_Ubah";
            this.btn_Ubah.Size = new System.Drawing.Size(75, 52);
            this.btn_Ubah.TabIndex = 20;
            this.btn_Ubah.Text = "Ubah";
            this.btn_Ubah.UseVisualStyleBackColor = false;
            this.btn_Ubah.Click += new System.EventHandler(this.button_Ubah_Click);
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_Tambah.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Tambah.ForeColor = System.Drawing.Color.White;
            this.btn_Tambah.Location = new System.Drawing.Point(422, 100);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Size = new System.Drawing.Size(75, 52);
            this.btn_Tambah.TabIndex = 19;
            this.btn_Tambah.Text = "Tambah";
            this.btn_Tambah.UseVisualStyleBackColor = false;
            this.btn_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // textBox_Foto
            // 
            this.textBox_Foto.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Foto.Location = new System.Drawing.Point(893, 97);
            this.textBox_Foto.Name = "textBox_Foto";
            this.textBox_Foto.ReadOnly = true;
            this.textBox_Foto.Size = new System.Drawing.Size(92, 27);
            this.textBox_Foto.TabIndex = 17;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.btn_Browse.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(795, 92);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(92, 60);
            this.btn_Browse.TabIndex = 18;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // pbx_Foto
            // 
            this.pbx_Foto.BackColor = System.Drawing.Color.White;
            this.pbx_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_Foto.Location = new System.Drawing.Point(893, 92);
            this.pbx_Foto.Name = "pbx_Foto";
            this.pbx_Foto.Size = new System.Drawing.Size(398, 242);
            this.pbx_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Foto.TabIndex = 27;
            this.pbx_Foto.TabStop = false;
            this.pbx_Foto.Click += new System.EventHandler(this.pictureBox_Foto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(374, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cari:";
            // 
            // tbx_Cari
            // 
            this.tbx_Cari.Font = new System.Drawing.Font("Arial", 10F);
            this.tbx_Cari.Location = new System.Drawing.Point(422, 307);
            this.tbx_Cari.Name = "tbx_Cari";
            this.tbx_Cari.Size = new System.Drawing.Size(350, 27);
            this.tbx_Cari.TabIndex = 24;
            // 
            // btn_Cari
            // 
            this.btn_Cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.btn_Cari.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Cari.ForeColor = System.Drawing.Color.White;
            this.btn_Cari.Location = new System.Drawing.Point(778, 293);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(75, 50);
            this.btn_Cari.TabIndex = 25;
            this.btn_Cari.Text = "Cari";
            this.btn_Cari.UseVisualStyleBackColor = false;
            this.btn_Cari.Click += new System.EventHandler(this.button_Cari_Click);
            // 
            // dgv_Mobil
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Mobil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Mobil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Mobil.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Mobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mobil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMobil,
            this.colPlatNomor,
            this.colMerk,
            this.colTipe,
            this.colTahun,
            this.colWarna,
            this.colHarga,
            this.colStatus});
            this.dgv_Mobil.Location = new System.Drawing.Point(366, 359);
            this.dgv_Mobil.Name = "dgv_Mobil";
            this.dgv_Mobil.ReadOnly = true;
            this.dgv_Mobil.RowHeadersWidth = 51;
            this.dgv_Mobil.Size = new System.Drawing.Size(928, 308);
            this.dgv_Mobil.TabIndex = 26;
            this.dgv_Mobil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Mobil_CellClick);
            // 
            // colIdMobil
            // 
            this.colIdMobil.HeaderText = "ID Mobil";
            this.colIdMobil.MinimumWidth = 6;
            this.colIdMobil.Name = "colIdMobil";
            this.colIdMobil.ReadOnly = true;
            // 
            // colPlatNomor
            // 
            this.colPlatNomor.HeaderText = "Plat Nomor";
            this.colPlatNomor.MinimumWidth = 6;
            this.colPlatNomor.Name = "colPlatNomor";
            this.colPlatNomor.ReadOnly = true;
            // 
            // colMerk
            // 
            this.colMerk.HeaderText = "Merk";
            this.colMerk.MinimumWidth = 6;
            this.colMerk.Name = "colMerk";
            this.colMerk.ReadOnly = true;
            // 
            // colTipe
            // 
            this.colTipe.HeaderText = "Tipe";
            this.colTipe.MinimumWidth = 6;
            this.colTipe.Name = "colTipe";
            this.colTipe.ReadOnly = true;
            // 
            // colTahun
            // 
            this.colTahun.HeaderText = "Tahun";
            this.colTahun.MinimumWidth = 6;
            this.colTahun.Name = "colTahun";
            this.colTahun.ReadOnly = true;
            // 
            // colWarna
            // 
            this.colWarna.HeaderText = "Warna";
            this.colWarna.MinimumWidth = 6;
            this.colWarna.Name = "colWarna";
            this.colWarna.ReadOnly = true;
            // 
            // colHarga
            // 
            this.colHarga.HeaderText = "Harga Sewa Per Hari";
            this.colHarga.MinimumWidth = 6;
            this.colHarga.Name = "colHarga";
            this.colHarga.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // mastermobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1319, 555);
            this.Controls.Add(this.dgv_Mobil);
            this.Controls.Add(this.pbx_Foto);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.tbx_Cari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.textBox_Foto);
            this.Controls.Add(this.btn_Ubah);
            this.Controls.Add(this.btn_Tambah);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mastermobil";
            this.Text = "Master Mobil";
            this.Load += new System.EventHandler(this.mastermobil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tahun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_IdMobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_PlatNomor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Tipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Merk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_Tahun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_Warna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_Harga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Foto;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Tambah;
        private System.Windows.Forms.Button btn_Ubah;
        private System.Windows.Forms.Button btn_Hapus;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_Cari;
        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.DataGridView dgv_Mobil;
        private System.Windows.Forms.PictureBox pbx_Foto;
        private System.Windows.Forms.Label lblModeAkses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatNomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}