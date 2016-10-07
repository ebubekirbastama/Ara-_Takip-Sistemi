using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Kütüphane_Otomasyonu.classlar;

namespace Araç_Kayıt_ve_Takip_Sistemi
{
    public partial class arac_update : MetroForm
    {
        public arac_update()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        degerler d = new degerler();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            k.sp("5", "sp_topdanci_blglr_update", "@brkt_nmr", "@src_adi", "@arac_cinsi", "@pilaka_no", "@gelis_nedeni", txt_brktnmr.Text, txt_src_adi.Text, txt_arac_cinsi.Text, txt_pilaka_no.Text, txt_gls_no.Text);
            d.arc_gtri(metroGrid1);
        }
        private void arac_update_Load(object sender, EventArgs e)
        {
            d.arc_gtri(metroGrid1);
        }
    }
}
