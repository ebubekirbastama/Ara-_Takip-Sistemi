using Araç_Kayıt_ve_Takip_Sistemi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu.classlar
{
    class degerler 
    {
        
        public int sayac { get; set; }
        private  static  string   personel_no ;
        public string prs
        {
            get
            {

                return personel_no;
            }
            set
            {
                personel_no = value;
            }
        }
        public string server_name { get; set; }
        public StreamReader sr { get; set; }
        public string s { get; set; }
        private string genel_mesaj = "Araç Kayıt & Takip Sistemi";
        private string Ekleme = "Kayıt işlemi Başarılı";
        private string Silme = "Silme İşlemi Başarılı";
        private string Guncelleme = "Güncelleme İşlemi Başarılı";
        private string Eklemesiz = "Kayıt işlemi Başarısız";
        public string gm
        {
            get
            {
                return genel_mesaj;
            }
            set
            {
                genel_mesaj = value;
            }
        }
        public string gm_1
        {
            get
            {

                return Ekleme;
            }
            set
            {
                Ekleme = value;
            }
        }
        public string gm_2
        {
            get
            {

                return Silme;
            }
            set
            {
                Silme = value;
            }
        }
        public string gm_3
        {
            get
            {

                return Guncelleme;
            }
            set
            {
                Guncelleme = value;
            }
        }
        public string gm_4
        {
            get
            {

                return Eklemesiz;
            }
            set
            {
                Eklemesiz = value;
            }
        }       
        public void frm_gtr(DataGridView datagrid)
        {
            kayit_islemleri k = new kayit_islemleri();
            k.Tablo("select id[No],frm_adi[Firma Adı],kyt_rh[Tarih] from frm_blglr", datagrid);
        }
        public void arc_gtri(DataGridView datagrid)
        {
            kayit_islemleri k = new kayit_islemleri();
            k.Tablo("select id[No],brkt_nmr[Barkot Numarası],arac_cinsi[Araç Modeli],gelis_nedeni[Geldiği Firma],kyt_rh[Kayıt Tarihi],pilaka_no[Plaka No],src_adi[Sürücü Adı]  from topdanci_blglr", datagrid);
        }
        public void prsnl_gtri(DataGridView datagrid, DataGridView datagrid1)
        {
            kayit_islemleri k = new kayit_islemleri();
            k.Tablo("select prsnl_brkt_nmr[Personel Barkot Numarası],personel_adi[Personel Adı],personel_soyadi[Personel Soyadı],personel_gorev[Personel Görevi]  from personel_blglr", datagrid);
            k.Tablo("select prsnl_brkt_nmr[Personel Barkot Numarası],personel_adi[Personel Adı],personel_soyadi[Personel Soyadı],personel_gorev[Personel Görevi]  from personel_blglr", datagrid1);
        }
        public void arc_gtr(ComboBox  combo)
        {
            kayit_islemleri k = new kayit_islemleri();
            k.Reader3("select * from frm_blglr", combo, "frm_adi");
        }
        public  void Temizle(Form Target)
        {
            
            try
            {
                foreach (Control control in Target.Controls)
                    if (control is TextBox)
                        ((TextBox)control).Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,gm.ToString ());
            }

        }//TexBox'ları Forechle Silme Komutu.
    }
}
