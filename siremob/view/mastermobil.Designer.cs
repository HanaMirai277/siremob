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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IdMobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PlatNomor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Batal = new System.Windows.Forms.Button();
            this.textBox_Merk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.textBox_Tipe = new System.Windows.Forms.TextBox();
            this.button_Ubah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.numericUpDown_Tahun = new System.Windows.Forms.NumericUpDown();
            this.textBox_Foto = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Warna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.pictureBox_Foto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Cari = new System.Windows.Forms.TextBox();
            this.button_Cari = new System.Windows.Forms.Button();
            this.dataGridView_Mobil = new System.Windows.Forms.DataGridView();
            this.colIdMobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatNomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tahun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mobil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.Controls.Add(this.textBox_IdMobil);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_PlatNomor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_Merk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_Tipe);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericUpDown_Tahun);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_Warna);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_Harga);
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
            // textBox_IdMobil
            // 
            this.textBox_IdMobil.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_IdMobil.Location = new System.Drawing.Point(15, 39);
            this.textBox_IdMobil.MaxLength = 3;
            this.textBox_IdMobil.Name = "textBox_IdMobil";
            this.textBox_IdMobil.Size = new System.Drawing.Size(315, 27);
            this.textBox_IdMobil.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plat Nomor";
            // 
            // textBox_PlatNomor
            // 
            this.textBox_PlatNomor.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_PlatNomor.Location = new System.Drawing.Point(15, 87);
            this.textBox_PlatNomor.Name = "textBox_PlatNomor";
            this.textBox_PlatNomor.Size = new System.Drawing.Size(315, 27);
            this.textBox_PlatNomor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Merk";
            // 
            // button_Batal
            // 
            this.button_Batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.button_Batal.Font = new System.Drawing.Font("Arial", 10F);
            this.button_Batal.ForeColor = System.Drawing.Color.White;
            this.button_Batal.Location = new System.Drawing.Point(671, 100);
            this.button_Batal.Name = "button_Batal";
            this.button_Batal.Size = new System.Drawing.Size(66, 40);
            this.button_Batal.TabIndex = 22;
            this.button_Batal.Text = "Batal";
            this.button_Batal.UseVisualStyleBackColor = false;
            this.button_Batal.Click += new System.EventHandler(this.button_Batal_Click);
            // 
            // textBox_Merk
            // 
            this.textBox_Merk.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Merk.Location = new System.Drawing.Point(15, 135);
            this.textBox_Merk.Name = "textBox_Merk";
            this.textBox_Merk.Size = new System.Drawing.Size(315, 27);
            this.textBox_Merk.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipe";
            // 
            // button_Hapus
            // 
            this.button_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.button_Hapus.Font = new System.Drawing.Font("Arial", 10F);
            this.button_Hapus.ForeColor = System.Drawing.Color.White;
            this.button_Hapus.Location = new System.Drawing.Point(588, 100);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 40);
            this.button_Hapus.TabIndex = 21;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = false;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // textBox_Tipe
            // 
            this.textBox_Tipe.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Tipe.Location = new System.Drawing.Point(15, 183);
            this.textBox_Tipe.Name = "textBox_Tipe";
            this.textBox_Tipe.Size = new System.Drawing.Size(315, 27);
            this.textBox_Tipe.TabIndex = 7;
            // 
            // button_Ubah
            // 
            this.button_Ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.button_Ubah.Font = new System.Drawing.Font("Arial", 10F);
            this.button_Ubah.ForeColor = System.Drawing.Color.White;
            this.button_Ubah.Location = new System.Drawing.Point(505, 100);
            this.button_Ubah.Name = "button_Ubah";
            this.button_Ubah.Size = new System.Drawing.Size(75, 40);
            this.button_Ubah.TabIndex = 20;
            this.button_Ubah.Text = "Ubah";
            this.button_Ubah.UseVisualStyleBackColor = false;
            this.button_Ubah.Click += new System.EventHandler(this.button_Ubah_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tahun";
            // 
            // button_Tambah
            // 
            this.button_Tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.button_Tambah.Font = new System.Drawing.Font("Arial", 10F);
            this.button_Tambah.ForeColor = System.Drawing.Color.White;
            this.button_Tambah.Location = new System.Drawing.Point(422, 100);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 40);
            this.button_Tambah.TabIndex = 19;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = false;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // numericUpDown_Tahun
            // 
            this.numericUpDown_Tahun.Font = new System.Drawing.Font("Arial", 10F);
            this.numericUpDown_Tahun.Location = new System.Drawing.Point(15, 231);
            this.numericUpDown_Tahun.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown_Tahun.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericUpDown_Tahun.Name = "numericUpDown_Tahun";
            this.numericUpDown_Tahun.Size = new System.Drawing.Size(315, 27);
            this.numericUpDown_Tahun.TabIndex = 9;
            this.numericUpDown_Tahun.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
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
            // button_Browse
            // 
            this.button_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.button_Browse.Font = new System.Drawing.Font("Arial", 9F);
            this.button_Browse.ForeColor = System.Drawing.Color.White;
            this.button_Browse.Location = new System.Drawing.Point(795, 92);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(92, 60);
            this.button_Browse.TabIndex = 18;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = false;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Warna";
            // 
            // textBox_Warna
            // 
            this.textBox_Warna.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Warna.Location = new System.Drawing.Point(15, 279);
            this.textBox_Warna.Name = "textBox_Warna";
            this.textBox_Warna.Size = new System.Drawing.Size(315, 27);
            this.textBox_Warna.TabIndex = 11;
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
            this.label8.Location = new System.Drawing.Point(15, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Harga Sewa Per Hari";
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Harga.Location = new System.Drawing.Point(15, 327);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(315, 27);
            this.textBox_Harga.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status Mobil";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak Tersedia",
            "Dalam Perbaikan"});
            this.comboBox_Status.Location = new System.Drawing.Point(15, 375);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(315, 27);
            this.comboBox_Status.TabIndex = 15;
            this.comboBox_Status.Text = "Tersedia";
            // 
            // pictureBox_Foto
            // 
            this.pictureBox_Foto.BackColor = System.Drawing.Color.White;
            this.pictureBox_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Foto.Location = new System.Drawing.Point(893, 92);
            this.pictureBox_Foto.Name = "pictureBox_Foto";
            this.pictureBox_Foto.Size = new System.Drawing.Size(398, 242);
            this.pictureBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Foto.TabIndex = 27;
            this.pictureBox_Foto.TabStop = false;
            this.pictureBox_Foto.Click += new System.EventHandler(this.pictureBox_Foto_Click);
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
            // textBox_Cari
            // 
            this.textBox_Cari.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox_Cari.Location = new System.Drawing.Point(422, 307);
            this.textBox_Cari.Name = "textBox_Cari";
            this.textBox_Cari.Size = new System.Drawing.Size(350, 27);
            this.textBox_Cari.TabIndex = 24;
            // 
            // button_Cari
            // 
            this.button_Cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(174)))));
            this.button_Cari.Font = new System.Drawing.Font("Arial", 10F);
            this.button_Cari.ForeColor = System.Drawing.Color.White;
            this.button_Cari.Location = new System.Drawing.Point(778, 293);
            this.button_Cari.Name = "button_Cari";
            this.button_Cari.Size = new System.Drawing.Size(75, 50);
            this.button_Cari.TabIndex = 25;
            this.button_Cari.Text = "Cari";
            this.button_Cari.UseVisualStyleBackColor = false;
            this.button_Cari.Click += new System.EventHandler(this.button_Cari_Click);
            // 
            // dataGridView_Mobil
            // 
            this.dataGridView_Mobil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Mobil.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Mobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Mobil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMobil,
            this.colPlatNomor,
            this.colMerk,
            this.colTipe,
            this.colTahun,
            this.colWarna,
            this.colHarga,
            this.colStatus});
            this.dataGridView_Mobil.Location = new System.Drawing.Point(366, 359);
            this.dataGridView_Mobil.Name = "dataGridView_Mobil";
            this.dataGridView_Mobil.ReadOnly = true;
            this.dataGridView_Mobil.RowHeadersWidth = 51;
            this.dataGridView_Mobil.Size = new System.Drawing.Size(928, 308);
            this.dataGridView_Mobil.TabIndex = 26;
            this.dataGridView_Mobil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Mobil_CellClick);
            // 
            // colIdMobil
            // 
            this.colIdMobil.HeaderText = "ID Mobil";
            this.colIdMobil.MinimumWidth = 6;
            this.colIdMobil.Name = "colIdMobil";
            this.colIdMobil.ReadOnly = true;
            this.colIdMobil.Width = 91;
            // 
            // colPlatNomor
            // 
            this.colPlatNomor.HeaderText = "Plat Nomor";
            this.colPlatNomor.MinimumWidth = 6;
            this.colPlatNomor.Name = "colPlatNomor";
            this.colPlatNomor.ReadOnly = true;
            this.colPlatNomor.Width = 109;
            // 
            // colMerk
            // 
            this.colMerk.HeaderText = "Merk";
            this.colMerk.MinimumWidth = 6;
            this.colMerk.Name = "colMerk";
            this.colMerk.ReadOnly = true;
            this.colMerk.Width = 74;
            // 
            // colTipe
            // 
            this.colTipe.HeaderText = "Tipe";
            this.colTipe.MinimumWidth = 6;
            this.colTipe.Name = "colTipe";
            this.colTipe.ReadOnly = true;
            this.colTipe.Width = 68;
            // 
            // colTahun
            // 
            this.colTahun.HeaderText = "Tahun";
            this.colTahun.MinimumWidth = 6;
            this.colTahun.Name = "colTahun";
            this.colTahun.ReadOnly = true;
            this.colTahun.Width = 81;
            // 
            // colWarna
            // 
            this.colWarna.HeaderText = "Warna";
            this.colWarna.MinimumWidth = 6;
            this.colWarna.Name = "colWarna";
            this.colWarna.ReadOnly = true;
            this.colWarna.Width = 87;
            // 
            // colHarga
            // 
            this.colHarga.HeaderText = "Harga Sewa Per Hari";
            this.colHarga.MinimumWidth = 6;
            this.colHarga.Name = "colHarga";
            this.colHarga.ReadOnly = true;
            this.colHarga.Width = 149;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 83;
            // 
            // mastermobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1319, 555);
            this.Controls.Add(this.dataGridView_Mobil);
            this.Controls.Add(this.pictureBox_Foto);
            this.Controls.Add(this.button_Cari);
            this.Controls.Add(this.textBox_Cari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Batal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.textBox_Foto);
            this.Controls.Add(this.button_Ubah);
            this.Controls.Add(this.button_Tambah);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mastermobil";
            this.Text = "Master Mobil";
            this.Load += new System.EventHandler(this.mastermobil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tahun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IdMobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PlatNomor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Merk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Tipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tahun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Warna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Foto;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Ubah;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Batal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Cari;
        private System.Windows.Forms.Button button_Cari;
        private System.Windows.Forms.DataGridView dataGridView_Mobil;
        private System.Windows.Forms.PictureBox pictureBox_Foto;
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