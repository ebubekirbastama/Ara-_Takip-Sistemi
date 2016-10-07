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
    public partial class firma_ekle : MetroForm
    {
        public firma_ekle()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            k.sp_ek("1", "sp_frm_blglr_insert", "@frm_adi",txt_firma .Text );
            txt_firma.Text = string.Empty;
            txt_firma.Focus();
        }
        

    }
}
