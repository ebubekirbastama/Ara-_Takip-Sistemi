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
    public partial class arac_delete : MetroForm
    {
        public arac_delete()
        {
            InitializeComponent();
        }
        degerler d = new degerler();
        kayit_islemleri k = new kayit_islemleri();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if ("OK" == MessageBox.Show("Seçilen veriyi silmekte eminmisiniz ?", d.gm, MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString())
            {
                k.sp("1", "sp_topdanci_blglr_Delete", "brkt_nmr", metroGrid1.CurrentRow.Cells[1].Value.ToString());
                d.arc_gtri(metroGrid1);
            }
        }

        private void arac_delete_Load(object sender, EventArgs e)
        {
            d.arc_gtri(metroGrid1);
        }
    }
}
