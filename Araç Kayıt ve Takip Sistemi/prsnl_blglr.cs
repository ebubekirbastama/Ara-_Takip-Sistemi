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
    public partial class prsnl_blglr : MetroForm
    {
        public prsnl_blglr()
        {
            InitializeComponent();
        }
        degerler d = new degerler();
        kayit_islemleri k = new kayit_islemleri();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            k.sp_ek("4", "sp_personel_blglr_insert", "@prsnl_brkt_nmr", "@personel_adi", "@personel_soyadi", "@personel_gorev",metroTextBox4 .Text ,metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text);
            d.prsnl_gtri(metroGrid1, metroGrid2);
            d.Temizle(this);            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            k.sp("4", "sp_personel_blglr_update","@prsnl_brkt_nmr","@personel_adi","@personel_soyadi", "@personel_gorev",txt_prsnl_brkt .Text , txtprsnl_adi.Text, txt_prsnl_syd.Text, txt_prsnl_grv.Text);
            d.prsnl_gtri(metroGrid1, metroGrid2);
            d.Temizle(this); 
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if ("OK" == MessageBox.Show("Seçilen veriyi silmekte eminmisiniz ?", d.gm, MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString())
            {
                k.sp("1", "sp_personel_blglr_Delete", "@prsnl_brkt_nmr",metroGrid1 .CurrentRow .Cells [0].Value .ToString ());
                d.prsnl_gtri(metroGrid1, metroGrid2);
            }
        }

        private void prsnl_blglr_Load(object sender, EventArgs e)
        {
            d.prsnl_gtri(metroGrid1,metroGrid2 );
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_prsnl_brkt.Text = metroGrid2.CurrentRow.Cells[0].Value.ToString();
            txtprsnl_adi .Text  = metroGrid2.CurrentRow.Cells[1].Value.ToString();
            txt_prsnl_syd .Text  = metroGrid2.CurrentRow.Cells[2].Value.ToString();
            txt_prsnl_grv .Text = metroGrid2.CurrentRow.Cells[3].Value.ToString();
        }
     
    }
}
