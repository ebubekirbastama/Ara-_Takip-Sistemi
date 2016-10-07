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
    public partial class frm_update : MetroForm
    {
        public frm_update()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        degerler d = new degerler();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            k.sp("2", "sp_frm_blglr_update", "@frm_adi", "@id", txt_firma.Text, metroGrid1.CurrentRow.Cells[0].Value.ToString());
            d.frm_gtr(metroGrid1);
        }

        private void frm_update_Load(object sender, EventArgs e)
        {
            d.frm_gtr(metroGrid1);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_firma.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
