using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Araç_Kayıt_ve_Takip_Sistemi
{
    public partial class firma_komuta_merekzi : MetroForm
    {
        public firma_komuta_merekzi()
        {
            InitializeComponent();
        }

        private void arac_giris_Click(object sender, EventArgs e)
        {
            firma_ekle fe = new firma_ekle();
            fe.ShowDialog();
        }

        private void arac_cikis_Click(object sender, EventArgs e)
        {
            frm_update fu = new frm_update();
            fu.ShowDialog();
        }

        private void firma_kayit_Click(object sender, EventArgs e)
        {
            firma_delete fd = new firma_delete();
            fd.ShowDialog();
        }
    }
}
