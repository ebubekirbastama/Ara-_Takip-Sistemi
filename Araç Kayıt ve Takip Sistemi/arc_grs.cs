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
    public partial class arc_grs : MetroForm
    {
        public arc_grs()
        {
            InitializeComponent();
        }
        kayit_islemleri k = new kayit_islemleri();
        degerler d = new degerler();
        baglanti bgl = new baglanti();
        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys .Enter )
            {
                try
                {
                    k.Reader2("select * from topdanci_blglr where brkt_nmr ='" + metroTextBox1.Text + "'", metroGrid1, "brkt_nmr", "src_adi", "arac_cinsi","pilaka_no","gelis_nedeni");
                    metroTextBox1.Text = "";
                    if (k.grs_kntr ==0)
                    {
                        MessageBox.Show("Topdancı bulunamadı yeni kayıt ekranı açılıyor",d.gm .ToString ());
                        arc_save ars = new arc_save();
                        ars.ShowDialog();  
                    }
                    else
                    {
                        k.grs_kntr = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, d.gm.ToString());
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < metroGrid1.RowCount ; i++)
                {
                    using ( SqlConnection con = bgl.baglanti_open())//Bağlantımızı açıyoruz)
                    {
                        SqlCommand kmt = new SqlCommand("sp_grs_bilgileri_insert", con);//Store procedurumuzun ismini yazıyoruz
                        kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                        kmt.Parameters.AddWithValue("@prsnl_brkt_nmr", d.prs);//Parametreleri giriyoruz
                        kmt.Parameters.AddWithValue("@brkt_nmr", metroGrid1.Rows[i].Cells[0].Value.ToString());//Parametreleri giriyoruz
                        kmt.Parameters.AddWithValue("@src_adi", metroGrid1.Rows[i].Cells[1].Value.ToString());//Parametreleri giriyoruz
                        kmt.Parameters.AddWithValue("@frm_adi", metroGrid1.Rows[i].Cells[4].Value.ToString());
                        kmt.Parameters.AddWithValue("@arac_model", metroGrid1.Rows[i].Cells[2].Value.ToString());//Parametreleri giriyoruz
                        kmt.Parameters.AddWithValue("@pilaka_no", metroGrid1.Rows[i].Cells[3].Value.ToString());//Parametreleri giriyoruz
                        kmt.Parameters.AddWithValue("@gelis_nedeni", metroGrid1.Rows[i].Cells[5].Value.ToString());//Parametreleri giriyoruz
                        kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.  
                    }     
                }
                for (int i = 0; i <=metroGrid1.RowCount-1; i++)
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
                MessageBox.Show(ex.Message,d.gm);
            }
                  
        }
        public void spi(params string [] param)
        {
            SqlConnection con = bgl.baglanti_open();
            SqlCommand kmt9 = new SqlCommand(param[0].ToString(), con);
            kmt9.CommandType = CommandType.StoredProcedure;
            kmt9.Parameters.AddWithValue(param[1].ToString(), param[10].ToString());
            kmt9.Parameters.AddWithValue(param[2].ToString(), param[11].ToString());
            kmt9.Parameters.AddWithValue(param[3].ToString(), param[12].ToString());
            kmt9.Parameters.AddWithValue(param[4].ToString(), param[13].ToString());
            kmt9.Parameters.AddWithValue(param[5].ToString(), param[14].ToString());
            kmt9.Parameters.AddWithValue(param[6].ToString(), param[15].ToString());
            kmt9.Parameters.AddWithValue(param[7].ToString(), param[16].ToString());
            kmt9.Parameters.AddWithValue(param[8].ToString(), param[17].ToString());
            kmt9.Parameters.AddWithValue(param[9].ToString(), param[18].ToString());
            kmt9.ExecuteNonQuery();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            arc_save ars = new arc_save();
            ars.ShowDialog();
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            if ("OK" == MessageBox.Show("Seçilen veriyi silmek istediğinizden emin misiniz?",d.gm , MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString())
            {
                foreach (DataGridViewCell oneCell in metroGrid1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        metroGrid1.Rows.RemoveAt(oneCell.RowIndex);
                        d.sayac = 0;
                    }
                }
            }
        }
    }
}
