using Kütüphane_Otomasyonu.classlar;
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
    public partial class arc_save : MetroForm
    {
        public arc_save()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        degerler d = new degerler();
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            
            k.sp_ek("5", "sp_topdanci_blglr_save", "@brkt_nmr", "@src_adi", "@arac_cinsi", "@pilaka_no", "@gelis_nedeni", txt_brktnmr.Text, txt_src_adi.Text, txt_arac_cinsi.Text, txt_pilaka_no.Text, txt_gls_no.Text);
            this.Close();
        }

        private void txt_gls_no_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void arc_save_Load(object sender, EventArgs e)
        {
            d.arc_gtr(txt_gls_no );
        }
    }
}
