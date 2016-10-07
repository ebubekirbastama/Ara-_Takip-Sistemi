using Kütüphane_Otomasyonu.classlar;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Araç_Kayıt_ve_Takip_Sistemi
{
    public partial class arac_cks : MetroForm
    {
        public arac_cks()
        {
            InitializeComponent();
        }
        degerler d = new degerler();
        baglanti bgl = new baglanti();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < metroGrid1.RowCount; i++)
                {
                    using (SqlConnection con = bgl.baglanti_open())//Bağlantımızı açıyoruz)
                    {
                        SqlCommand kmt = new SqlCommand("sp_cikis_bilgileri_insert", con);//Store procedurumuzun ismini yazıyoruz
                        kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                        kmt.Parameters.AddWithValue("@brkt_nmr", metroGrid1.Rows[i].Cells[0].Value.ToString());//Parametreleri giriyoruz 
                        kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.  
                    }
                }
                for (int i = 0; i <= metroGrid1.RowCount; i++)
                {
                    if (metroGrid1.Rows[i].Cells[0].Value == null)
                    { }
                    else
                    {
                        metroGrid1.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, d.gm);
            }
        }
        private void txt_brkt_nmr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    metroGrid1.Rows.Add();
                    metroGrid1.Rows[d.sayac].Cells[0].Value = txt_brkt_nmr.Text;
                    txt_brkt_nmr.Text = "";
                    d.sayac++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, d.gm.ToString());
                }
            }
        }
    }
}
