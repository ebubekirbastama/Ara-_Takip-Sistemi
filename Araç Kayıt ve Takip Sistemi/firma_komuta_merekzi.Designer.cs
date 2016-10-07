namespace Araç_Kayıt_ve_Takip_Sistemi
{
    partial class firma_komuta_merekzi
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
            this.arac_cikis = new System.Windows.Forms.PictureBox();
            this.arac_giris = new System.Windows.Forms.PictureBox();
            this.firma_kayit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arac_cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_giris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // arac_cikis
            // 
            this.arac_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arac_cikis.Image = global::Araç_Kayıt_ve_Takip_Sistemi.Properties.Resources.Update;
            this.arac_cikis.Location = new System.Drawing.Point(311, 80);
            this.arac_cikis.Name = "arac_cikis";
            this.arac_cikis.Size = new System.Drawing.Size(196, 141);
            this.arac_cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arac_cikis.TabIndex = 9;
            this.arac_cikis.TabStop = false;
            this.arac_cikis.Click += new System.EventHandler(this.arac_cikis_Click);
            // 
            // arac_giris
            // 
            this.arac_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arac_giris.Image = global::Araç_Kayıt_ve_Takip_Sistemi.Properties.Resources.Add;
            this.arac_giris.Location = new System.Drawing.Point(60, 80);
            this.arac_giris.Name = "arac_giris";
            this.arac_giris.Size = new System.Drawing.Size(196, 141);
            this.arac_giris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arac_giris.TabIndex = 8;
            this.arac_giris.TabStop = false;
            this.arac_giris.Click += new System.EventHandler(this.arac_giris_Click);
            // 
            // firma_kayit
            // 
            this.firma_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firma_kayit.Image = global::Araç_Kayıt_ve_Takip_Sistemi.Properties.Resources.Delete;
            this.firma_kayit.Location = new System.Drawing.Point(540, 80);
            this.firma_kayit.Name = "firma_kayit";
            this.firma_kayit.Size = new System.Drawing.Size(190, 141);
            this.firma_kayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firma_kayit.TabIndex = 7;
            this.firma_kayit.TabStop = false;
            this.firma_kayit.Click += new System.EventHandler(this.firma_kayit_Click);
            // 
            // firma_komuta_merekzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 300);
            this.Controls.Add(this.arac_cikis);
            this.Controls.Add(this.arac_giris);
            this.Controls.Add(this.firma_kayit);
            this.Name = "firma_komuta_merekzi";
            this.Text = "Firma Komuta merkezi";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.arac_cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_giris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox arac_cikis;
        private System.Windows.Forms.PictureBox arac_giris;
        private System.Windows.Forms.PictureBox firma_kayit;
    }
}