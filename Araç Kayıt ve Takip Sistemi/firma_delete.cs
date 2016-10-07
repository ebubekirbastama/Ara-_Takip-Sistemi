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
    public partial class firma_delete : MetroForm
    {
        public firma_delete()
        {
            InitializeComponent();
        }
        degerler d = new degerler();
        kayit_islemleri K = new kayit_islemleri();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow .Cells[0].Value .ToString() !=null )
            {
                if ("OK" == MessageBox.Show("Seçilen veriyi silmek istediğinizden emin misiniz?",d.gm , MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString())
                {
                    K.sp("1", "sp_frm_blglr_delete","@id", metroGrid1.CurrentRow.Cells[0].Value.ToString());
                    d.frm_gtr(metroGrid1);
                }
            }
            
        }
        private void firma_delete_Load(object sender, EventArgs e)
        {
            d.frm_gtr(metroGrid1 );
        }
    }
}
