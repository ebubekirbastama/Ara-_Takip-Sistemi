//Bu Yapı By Ebubekir Bastama tarından dizayn edilmiş'dir.
//Soru ve görüşleriniz için online 05554128854
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Kütüphane_Otomasyonu.classlar;
using System.Data;

//desing by Ebubekir bastama(c.)
namespace Araç_Kayıt_ve_Takip_Sistemi
{
    class baglanti:degerler 
    {
        public void ayr()
        {
            sr = File.OpenText(@"C:\ayar.txt");
            si = sr.ReadLine();
            svr = si;
            sr.Close();
        }
        public string svr
        {
            get
            {

                return server_name;
            }
            set
            {
                server_name = value;
            }
        }
        public string si
        {
            get
            {

                return s;
            }
            set
            {
                s = value;
            }
        }
        public SqlConnection baglanti_open()
        {
          
            //ebubekirbastama
            SqlConnection con = new SqlConnection(@"Server=" + svr + "; Integrated Security=true; Database=arac_takip_otomasyonu;Pooling=true");//Bağlantı cümlemiz

            if (con.State == ConnectionState.Closed) // System.Data.SqlClient.ConnectionState using System.Data; kütüphanesinden gelir
            {
                con.Open();//Bağlantıyı Aç
            }
            return con;//con döndür
        }
        public SqlConnection baglanti_close()
        {

            //ebubekirbastama
            SqlConnection con = new SqlConnection(@"Server=" + svr + "; Integrated Security=true; Database=arac_takip_otomasyonu;Pooling=true");//Bağlantı cümlemiz

            if (con.State == ConnectionState.Open ) // System.Data.SqlClient.ConnectionState using System.Data; kütüphanesinden gelir
            {
                con.Close();//Bağlantıyı Aç
            }
            return con;//con döndür
        }
    }
}
