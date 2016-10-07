using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Araç_Kayıt_ve_Takip_Sistemi
{
    public partial class Komutamerkezi : MetroForm
    {
        public Komutamerkezi()
        {
            InitializeComponent();
        }

        private void arac_kayit_Click(object sender, EventArgs e)
        {
            Arac_firma_kontrol_Merkezi afkm = new Arac_firma_kontrol_Merkezi();
            afkm.ShowDialog();
        }
        private void arac_giris_Click(object sender, EventArgs e)
        {
            arc_grs ag = new arc_grs();
            ag.ShowDialog ();
        }
        private void arac_cikis_Click(object sender, EventArgs e)
        {
            arac_cks ac = new arac_cks();
            ac.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            firma_komuta_merekzi fkm = new firma_komuta_merekzi();
            fkm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            prsnl_blglr p = new prsnl_blglr();
            p.ShowDialog();
        }

    }
}
