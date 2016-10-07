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
    public partial class Arac_firma_kontrol_Merkezi : MetroForm
    {
        public Arac_firma_kontrol_Merkezi()
        {
            InitializeComponent();
        }

        private void arac_giris_Click(object sender, EventArgs e)
        {
            arc_save a = new arc_save();
            a.ShowDialog();
        }

        private void arac_cikis_Click(object sender, EventArgs e)
        {
            arac_update au = new arac_update();
            au.ShowDialog();
        }

        private void firma_kayit_Click(object sender, EventArgs e)
        {
            arac_delete ad = new arac_delete();
            ad.ShowDialog();
        }
    }
}
