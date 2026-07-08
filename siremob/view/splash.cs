using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using siremob.service;

namespace siremob.view
{
    public partial class splash : Form
    {
        private int progress = 0;
        private bool dbCheckStarted = false;
        private bool dbCheckOk = true;

        // Pesan status yang ditampilkan seiring bertambahnya progress
        private readonly int[] ambangStatus = new int[] { 0, 20, 55, 80, 100 };
        private readonly string[] pesanStatus = new string[]
        {
            "Memuat aplikasi...",
            "Menghubungkan ke database...",
            "Menyiapkan data petugas...",
            "Menyiapkan tampilan...",
            "Selesai, membuka halaman login..."
        };

        public splash()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += new EventHandler(splash_Load);
        }

        private void panelLogoCircle_Paint(object sender, PaintEventArgs e)
        {
            // Membuat panel logo menjadi lingkaran sempurna
            Panel p = (Panel)sender;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, p.Width - 1, p.Height - 1);
            p.Region = new Region(path);
        }

        private void lblLogoGlyph_Paint(object sender, PaintEventArgs e)
        {
            // Menggambar ikon mobil sederhana secara vektor (menghindari masalah rendering emoji)
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color warnaIkon = Color.FromArgb(15, 25, 38);
            using (Brush brush = new SolidBrush(warnaIkon))
            using (Pen pen = new Pen(warnaIkon, 2.2f))
            {
                Rectangle bodyBounds = new Rectangle(14, 32, 52, 18);

                // Badan mobil (bentuk membulat)
                using (GraphicsPath body = new GraphicsPath())
                {
                    body.AddArc(bodyBounds.X, bodyBounds.Y, 14, 14, 180, 90);
                    body.AddArc(bodyBounds.Right - 14, bodyBounds.Y, 14, 14, 270, 90);
                    body.AddArc(bodyBounds.Right - 14, bodyBounds.Bottom - 14, 14, 14, 0, 90);
                    body.AddArc(bodyBounds.X, bodyBounds.Bottom - 14, 14, 14, 90, 90);
                    body.CloseFigure();
                    g.FillPath(brush, body);
                }

                // Atap / kabin mobil
                Point[] kabin = new Point[]
                {
                    new Point(22, 32),
                    new Point(30, 18),
                    new Point(50, 18),
                    new Point(58, 32)
                };
                g.FillPolygon(brush, kabin);

                // Kaca jendela (potongan warna latar agar terlihat berlubang)
                using (Brush kaca = new SolidBrush(Color.FromArgb(102, 205, 170)))
                {
                    g.FillPolygon(kaca, new Point[]
                    {
                        new Point(25, 30),
                        new Point(31, 21),
                        new Point(39, 21),
                        new Point(39, 30)
                    });
                    g.FillPolygon(kaca, new Point[]
                    {
                        new Point(41, 30),
                        new Point(41, 21),
                        new Point(49, 21),
                        new Point(55, 30)
                    });
                }

                // Roda
                using (Brush roda = new SolidBrush(warnaIkon))
                {
                    g.FillEllipse(roda, 18, 44, 12, 12);
                    g.FillEllipse(roda, 50, 44, 12, 12);
                }
                using (Brush velg = new SolidBrush(Color.FromArgb(102, 205, 170)))
                {
                    g.FillEllipse(velg, 21, 47, 6, 6);
                    g.FillEllipse(velg, 53, 47, 6, 6);
                }
            }
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            // Naikkan progress secara halus menuju 100
            progress += 2;
            if (progress > 100) progress = 100;

            int fillWidth = (int)(panelProgressTrack.Width * (progress / 100.0));
            panelProgressFill.Width = fillWidth;

            // Update pesan status sesuai tahapan
            string pesanTerkini = pesanStatus[0];
            for (int i = 0; i < ambangStatus.Length; i++)
            {
                if (progress >= ambangStatus[i]) pesanTerkini = pesanStatus[i];
            }
            lblStatus.Text = pesanTerkini;

            // Di tengah proses, coba pastikan koneksi & seed akun default petugas
            if (!dbCheckStarted && progress >= 20)
            {
                dbCheckStarted = true;
                try
                {
                    // Constructor login_serve otomatis mengecek & mengisi akun default jika tabel kosong
                    new login_serve();
                    dbCheckOk = true;
                }
                catch
                {
                    dbCheckOk = false;
                }
            }

            if (progress >= 100)
            {
                timerLoad.Stop();
                BukaLogin();
            }
        }

        private void BukaLogin()
        {
            if (!dbCheckOk)
            {
                MessageBox.Show(
                    "Tidak dapat terhubung ke database. Pastikan MySQL server sudah aktif.\nAplikasi akan tetap membuka halaman login.",
                    "Peringatan Koneksi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            login loginForm = new login();
            loginForm.Show();

            // Sembunyikan (bukan Close) supaya message loop utama aplikasi tetap berjalan
            this.Hide();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            panelProgressFill.Width = 0;
            timerLoad.Start();
        }
    }
}
