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
    public partial class k_giris : MetroForm
    {
        public k_giris()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        degerler d = new degerler();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            k.sp_k_grs ("4", "sp_k_gris", "@prsnl_brkt_nmr", "@personel_adi", "@personel_soyadi", "@personel_gorev", txt_brkt_nmr.Text, txt_prsnl_adi.Text, txt_prsnl_syd.Text, txt_prsnl_grv.Text);
            if (k.grs_drm !=0)
            {
                var df= txt_brkt_nmr.Text;
                d.prs  = df;
                pictureBox2.Image = global::Araç_Kayıt_ve_Takip_Sistemi.Properties.Resources.decrypted;
                Komutamerkezi ki = new Komutamerkezi();
                 this.Hide(); 
                ki.ShowDialog();                 
            }            
        }
        private void txt_brkt_nmr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                k.Reader1("select * from personel_blglr where prsnl_brkt_nmr='" + txt_brkt_nmr.Text  + "'",txt_prsnl_adi, txt_prsnl_syd, txt_prsnl_grv, "personel_adi", "personel_soyadi", "personel_gorev"); 
            }        
        }
        private void k_giris_Load(object sender, EventArgs e)
        {
            txt_brkt_nmr.Focus();
        }

    }
}
