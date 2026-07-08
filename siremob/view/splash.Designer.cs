namespace siremob.view
{
    partial class splash
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
            this.components = new System.ComponentModel.Container();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panelLogoCircle = new System.Windows.Forms.Panel();
            this.lblLogoGlyph = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelProgressTrack = new System.Windows.Forms.Panel();
            this.panelProgressFill = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelLogoCircle.SuspendLayout();
            this.panelProgressTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 30;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // panelLogoCircle
            // 
            this.panelLogoCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.panelLogoCircle.Controls.Add(this.lblLogoGlyph);
            this.panelLogoCircle.Location = new System.Drawing.Point(210, 60);
            this.panelLogoCircle.Name = "panelLogoCircle";
            this.panelLogoCircle.Size = new System.Drawing.Size(80, 80);
            this.panelLogoCircle.TabIndex = 0;
            this.panelLogoCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogoCircle_Paint);
            // 
            // lblLogoGlyph
            // 
            this.lblLogoGlyph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoGlyph.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoGlyph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.lblLogoGlyph.Location = new System.Drawing.Point(0, 0);
            this.lblLogoGlyph.Name = "lblLogoGlyph";
            this.lblLogoGlyph.Size = new System.Drawing.Size(80, 80);
            this.lblLogoGlyph.TabIndex = 0;
            this.lblLogoGlyph.Text = "";
            this.lblLogoGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogoGlyph.Paint += new System.Windows.Forms.PaintEventHandler(this.lblLogoGlyph_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.lblTitle.Location = new System.Drawing.Point(140, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SIREMOB";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.lblSub.Location = new System.Drawing.Point(155, 218);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(190, 24);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Sistem Rental Mobil";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lblStatus.Location = new System.Drawing.Point(50, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 22);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Memuat aplikasi...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProgressTrack
            // 
            this.panelProgressTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panelProgressTrack.Controls.Add(this.panelProgressFill);
            this.panelProgressTrack.Location = new System.Drawing.Point(50, 330);
            this.panelProgressTrack.Name = "panelProgressTrack";
            this.panelProgressTrack.Size = new System.Drawing.Size(400, 8);
            this.panelProgressTrack.TabIndex = 4;
            // 
            // panelProgressFill
            // 
            this.panelProgressFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.panelProgressFill.Location = new System.Drawing.Point(0, 0);
            this.panelProgressFill.Name = "panelProgressFill";
            this.panelProgressFill.Size = new System.Drawing.Size(0, 8);
            this.panelProgressFill.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = false;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.lblVersion.Location = new System.Drawing.Point(50, 365);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(400, 20);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "v1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.panelProgressTrack);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelLogoCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIREMOB";
            this.panelLogoCircle.ResumeLayout(false);
            this.panelProgressTrack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Panel panelLogoCircle;
        private System.Windows.Forms.Label lblLogoGlyph;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelProgressTrack;
        private System.Windows.Forms.Panel panelProgressFill;
        private System.Windows.Forms.Label lblVersion;
    }
}
