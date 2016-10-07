using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Araç_Kayıt_ve_Takip_Sistemi_İT_
{
  
        class degerler 
        {

            public int sayac { get; set; }
            public string server_name { get; set; }
            public StreamReader sr { get; set; }
            public DataTable dt { get; set; }
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
   
        }

}
