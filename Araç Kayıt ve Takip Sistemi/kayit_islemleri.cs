//Bu Yapı By Ebubekir Bastama tarından dizayn edilmiş'dir.
//Soru ve görüşleriniz için online 05554128854
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Araç_Kayıt_ve_Takip_Sistemi;
using MetroFramework.Controls;

namespace Kütüphane_Otomasyonu.classlar
{
    class kayit_islemleri:baglanti 
    {
        public int grs_drm;
        public int grs_kntr;
        public SqlDataReader Reader2(string sqlcumle, DataGridView datagrid,params string  []param )
        {
            SqlCommand komut = new SqlCommand("" + sqlcumle + "",baglanti_open ());
            SqlDataReader rdr = komut.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    grs_kntr = 1;
                    datagrid.Rows.Add();
                    datagrid.Rows[sayac].Cells[0].Value = rdr[param[0].ToString()].ToString();
                    datagrid.Rows[sayac].Cells[1].Value = rdr[param[1].ToString()].ToString();
                    datagrid.Rows[sayac].Cells[2].Value = rdr[param[2].ToString()].ToString();
                    datagrid.Rows[sayac].Cells[3].Value = rdr[param[3].ToString()].ToString();
                    datagrid.Rows[sayac].Cells[4].Value = rdr[param[4].ToString()].ToString();
                    datagrid.Rows[sayac].Cells[5].Value = "ÜRÜN";
                    sayac++;
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,gm.ToString ());
            }
            rdr.Dispose();
            baglanti_close();
            return rdr;
        }
        public SqlDataReader Reader1(string sqlcumle, MetroTextBox txt1, MetroTextBox txt2,MetroTextBox txt3,params string[] param)
        {
            SqlCommand komut = new SqlCommand("" + sqlcumle + "", baglanti_open());
            SqlDataReader rdr = komut.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    txt1.Text = rdr[param[0].ToString()].ToString();
                    txt2.Text = rdr[param[1].ToString()].ToString();
                    txt3.Text = rdr[param[2].ToString()].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, gm.ToString());
            }
            rdr.Dispose();
            baglanti_close();
            return rdr;
        }
        public void sp(string cml ,params string[] param)
        {
            try
            {

                SqlConnection con = baglanti_open();
                switch (cml)
                {
                    case "1":
                        SqlCommand kmt1 = new SqlCommand(param[0].ToString(), con);
                        kmt1.CommandType = CommandType.StoredProcedure;
                        kmt1.Parameters.AddWithValue(param[1].ToString(), param[2].ToString());
                        kmt1.ExecuteNonQuery();
                       
                        break;
                    case "2":
                SqlCommand kmt2 = new SqlCommand(param[0].ToString(), con);
kmt2.CommandType = CommandType.StoredProcedure;
kmt2.Parameters.AddWithValue(param[1].ToString(), param[3].ToString());
kmt2.Parameters.AddWithValue(param[2].ToString(), param[4].ToString());
kmt2.ExecuteNonQuery();

                        break;
                    case "3":
                      SqlCommand kmt3 = new SqlCommand(param[0].ToString(), con);
kmt3.CommandType = CommandType.StoredProcedure;
kmt3.Parameters.AddWithValue(param[1].ToString(), param[4].ToString());
kmt3.Parameters.AddWithValue(param[2].ToString(), param[5].ToString());
kmt3.Parameters.AddWithValue(param[3].ToString(), param[6].ToString());
kmt3.ExecuteNonQuery();

                        break;
                    case "4":
                  SqlCommand kmt4 = new SqlCommand(param[0].ToString(), con);
kmt4.CommandType = CommandType.StoredProcedure;
kmt4.Parameters.AddWithValue(param[1].ToString(), param[5].ToString());
kmt4.Parameters.AddWithValue(param[2].ToString(), param[6].ToString());
kmt4.Parameters.AddWithValue(param[3].ToString(), param[7].ToString());
kmt4.Parameters.AddWithValue(param[4].ToString(), param[8].ToString());
kmt4.ExecuteNonQuery();

                        break;
                    case "5":
                 SqlCommand kmt5 = new SqlCommand(param[0].ToString(), con);
kmt5.CommandType = CommandType.StoredProcedure;
kmt5.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
kmt5.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
kmt5.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
kmt5.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
kmt5.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
kmt5.ExecuteNonQuery();

                        break;
                    case "6":
         SqlCommand kmt6 = new SqlCommand(param[0].ToString(), con);
kmt6.CommandType = CommandType.StoredProcedure;
kmt6.Parameters.AddWithValue(param[1].ToString(), param[7].ToString());
kmt6.Parameters.AddWithValue(param[2].ToString(), param[8].ToString());
kmt6.Parameters.AddWithValue(param[3].ToString(), param[9].ToString());
kmt6.Parameters.AddWithValue(param[4].ToString(), param[10].ToString());
kmt6.Parameters.AddWithValue(param[5].ToString(), param[11].ToString());
kmt6.Parameters.AddWithValue(param[6].ToString(), param[12].ToString());
kmt6.ExecuteNonQuery();

                        break;
                    case "7":
                SqlCommand kmt7 = new SqlCommand(param[0].ToString(), con);
kmt7.CommandType = CommandType.StoredProcedure;
kmt7.Parameters.AddWithValue(param[1].ToString(), param[8].ToString());
kmt7.Parameters.AddWithValue(param[2].ToString(), param[9].ToString());
kmt7.Parameters.AddWithValue(param[3].ToString(), param[10].ToString());
kmt7.Parameters.AddWithValue(param[4].ToString(), param[11].ToString());
kmt7.Parameters.AddWithValue(param[5].ToString(), param[12].ToString());
kmt7.Parameters.AddWithValue(param[6].ToString(), param[13].ToString());
kmt7.Parameters.AddWithValue(param[7].ToString(), param[14].ToString());
kmt7.ExecuteNonQuery();

                        break;
                    case "8":
              SqlCommand kmt8 = new SqlCommand(param[0].ToString(), con);
kmt8.CommandType = CommandType.StoredProcedure;
kmt8.Parameters.AddWithValue(param[1].ToString(), param[9].ToString());
kmt8.Parameters.AddWithValue(param[2].ToString(), param[10].ToString());
kmt8.Parameters.AddWithValue(param[3].ToString(), param[11].ToString());
kmt8.Parameters.AddWithValue(param[4].ToString(), param[12].ToString());
kmt8.Parameters.AddWithValue(param[5].ToString(), param[13].ToString());
kmt8.Parameters.AddWithValue(param[6].ToString(), param[14].ToString());
kmt8.Parameters.AddWithValue(param[7].ToString(), param[15].ToString());
kmt8.Parameters.AddWithValue(param[8].ToString(), param[16].ToString());
kmt8.ExecuteNonQuery();

                        break;
                    case "9":
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
                        break;
                    case "10":
                    SqlCommand kmt10 = new SqlCommand(param[0].ToString(), con);
kmt10.CommandType = CommandType.StoredProcedure;
kmt10.Parameters.AddWithValue(param[1].ToString(), param[11].ToString());
kmt10.Parameters.AddWithValue(param[2].ToString(), param[12].ToString());
kmt10.Parameters.AddWithValue(param[3].ToString(), param[13].ToString());
kmt10.Parameters.AddWithValue(param[4].ToString(), param[14].ToString());
kmt10.Parameters.AddWithValue(param[5].ToString(), param[15].ToString());
kmt10.Parameters.AddWithValue(param[6].ToString(), param[16].ToString());
kmt10.Parameters.AddWithValue(param[7].ToString(), param[17].ToString());
kmt10.Parameters.AddWithValue(param[8].ToString(), param[18].ToString());
kmt10.Parameters.AddWithValue(param[9].ToString(), param[19].ToString());
kmt10.Parameters.AddWithValue(param[10].ToString(), param[20].ToString());
kmt10.ExecuteNonQuery();
                        break;
                    case "11":
                  SqlCommand kmt11 = new SqlCommand(param[0].ToString(), con);
kmt11.CommandType = CommandType.StoredProcedure;
kmt11.Parameters.AddWithValue(param[1].ToString(), param[12].ToString());
kmt11.Parameters.AddWithValue(param[2].ToString(), param[13].ToString());
kmt11.Parameters.AddWithValue(param[3].ToString(), param[14].ToString());
kmt11.Parameters.AddWithValue(param[4].ToString(), param[15].ToString());
kmt11.Parameters.AddWithValue(param[5].ToString(), param[16].ToString());
kmt11.Parameters.AddWithValue(param[6].ToString(), param[17].ToString());
kmt11.Parameters.AddWithValue(param[7].ToString(), param[18].ToString());
kmt11.Parameters.AddWithValue(param[8].ToString(), param[19].ToString());
kmt11.Parameters.AddWithValue(param[9].ToString(), param[20].ToString());
kmt11.Parameters.AddWithValue(param[10].ToString(), param[21].ToString());
kmt11.Parameters.AddWithValue(param[11].ToString(), param[22].ToString());
kmt11.ExecuteNonQuery();
                        break;
                    case "12":
           SqlCommand kmt12 = new SqlCommand(param[0].ToString(), con);
kmt12.CommandType = CommandType.StoredProcedure;
kmt12.Parameters.AddWithValue(param[69].ToString(), param[12].ToString());
kmt12.Parameters.AddWithValue(param[70].ToString(), param[13].ToString());
kmt12.Parameters.AddWithValue(param[71].ToString(), param[14].ToString());
kmt12.Parameters.AddWithValue(param[72].ToString(), param[15].ToString());
kmt12.Parameters.AddWithValue(param[73].ToString(), param[16].ToString());
kmt12.Parameters.AddWithValue(param[74].ToString(), param[17].ToString());
kmt12.Parameters.AddWithValue(param[75].ToString(), param[18].ToString());
kmt12.Parameters.AddWithValue(param[76].ToString(), param[19].ToString());
kmt12.Parameters.AddWithValue(param[77].ToString(), param[20].ToString());
kmt12.Parameters.AddWithValue(param[78].ToString(), param[21].ToString());
kmt12.Parameters.AddWithValue(param[79].ToString(), param[22].ToString());
kmt12.Parameters.AddWithValue(param[80].ToString(), param[23].ToString());
kmt12.ExecuteNonQuery();
                        break;
                    case "13":
           SqlCommand kmt13 = new SqlCommand(param[0].ToString(), con);
kmt13.CommandType = CommandType.StoredProcedure;
kmt13.Parameters.AddWithValue(param[1].ToString(), param[14].ToString());
kmt13.Parameters.AddWithValue(param[2].ToString(), param[15].ToString());
kmt13.Parameters.AddWithValue(param[3].ToString(), param[16].ToString());
kmt13.Parameters.AddWithValue(param[4].ToString(), param[17].ToString());
kmt13.Parameters.AddWithValue(param[5].ToString(), param[18].ToString());
kmt13.Parameters.AddWithValue(param[6].ToString(), param[19].ToString());
kmt13.Parameters.AddWithValue(param[7].ToString(), param[20].ToString());
kmt13.Parameters.AddWithValue(param[8].ToString(), param[21].ToString());
kmt13.Parameters.AddWithValue(param[9].ToString(), param[22].ToString());
kmt13.Parameters.AddWithValue(param[10].ToString(), param[23].ToString());
kmt13.Parameters.AddWithValue(param[11].ToString(), param[24].ToString());
kmt13.Parameters.AddWithValue(param[12].ToString(), param[25].ToString());
kmt13.Parameters.AddWithValue(param[13].ToString(), param[26].ToString());
kmt13.ExecuteNonQuery();
                        break;
                    case "14":
         SqlCommand kmt14 = new SqlCommand(param[0].ToString(), con);
kmt14.CommandType = CommandType.StoredProcedure;
kmt14.Parameters.AddWithValue(param[1].ToString(), param[15].ToString());
kmt14.Parameters.AddWithValue(param[2].ToString(), param[16].ToString());
kmt14.Parameters.AddWithValue(param[3].ToString(), param[17].ToString());
kmt14.Parameters.AddWithValue(param[4].ToString(), param[18].ToString());
kmt14.Parameters.AddWithValue(param[5].ToString(), param[19].ToString());
kmt14.Parameters.AddWithValue(param[6].ToString(), param[20].ToString());
kmt14.Parameters.AddWithValue(param[7].ToString(), param[21].ToString());
kmt14.Parameters.AddWithValue(param[8].ToString(), param[22].ToString());
kmt14.Parameters.AddWithValue(param[9].ToString(), param[23].ToString());
kmt14.Parameters.AddWithValue(param[10].ToString(), param[24].ToString());
kmt14.Parameters.AddWithValue(param[11].ToString(), param[25].ToString());
kmt14.Parameters.AddWithValue(param[12].ToString(), param[26].ToString());
kmt14.Parameters.AddWithValue(param[13].ToString(), param[27].ToString());
kmt14.Parameters.AddWithValue(param[14].ToString(), param[28].ToString());
kmt14.ExecuteNonQuery();
                        break;
                    case "15":
        SqlCommand kmt15 = new SqlCommand(param[0].ToString(), con);
kmt15.CommandType = CommandType.StoredProcedure;
kmt15.Parameters.AddWithValue(param[1].ToString(), param[16].ToString());
kmt15.Parameters.AddWithValue(param[2].ToString(), param[17].ToString());
kmt15.Parameters.AddWithValue(param[3].ToString(), param[18].ToString());
kmt15.Parameters.AddWithValue(param[4].ToString(), param[19].ToString());
kmt15.Parameters.AddWithValue(param[5].ToString(), param[20].ToString());
kmt15.Parameters.AddWithValue(param[6].ToString(), param[21].ToString());
kmt15.Parameters.AddWithValue(param[7].ToString(), param[22].ToString());
kmt15.Parameters.AddWithValue(param[8].ToString(), param[23].ToString());
kmt15.Parameters.AddWithValue(param[9].ToString(), param[24].ToString());
kmt15.Parameters.AddWithValue(param[10].ToString(), param[25].ToString());
kmt15.Parameters.AddWithValue(param[11].ToString(), param[26].ToString());
kmt15.Parameters.AddWithValue(param[12].ToString(), param[27].ToString());
kmt15.Parameters.AddWithValue(param[13].ToString(), param[28].ToString());
kmt15.Parameters.AddWithValue(param[14].ToString(), param[29].ToString());
kmt15.Parameters.AddWithValue(param[15].ToString(), param[30].ToString());
kmt15.ExecuteNonQuery();
                        break;
                    case "16":
              SqlCommand kmt16 = new SqlCommand(param[0].ToString(), con);
kmt16.CommandType = CommandType.StoredProcedure;
kmt16.Parameters.AddWithValue(param[1].ToString(), param[17].ToString());
kmt16.Parameters.AddWithValue(param[2].ToString(), param[18].ToString());
kmt16.Parameters.AddWithValue(param[3].ToString(), param[19].ToString());
kmt16.Parameters.AddWithValue(param[4].ToString(), param[20].ToString());
kmt16.Parameters.AddWithValue(param[5].ToString(), param[21].ToString());
kmt16.Parameters.AddWithValue(param[6].ToString(), param[22].ToString());
kmt16.Parameters.AddWithValue(param[7].ToString(), param[23].ToString());
kmt16.Parameters.AddWithValue(param[8].ToString(), param[24].ToString());
kmt16.Parameters.AddWithValue(param[9].ToString(), param[25].ToString());
kmt16.Parameters.AddWithValue(param[10].ToString(), param[26].ToString());
kmt16.Parameters.AddWithValue(param[11].ToString(), param[27].ToString());
kmt16.Parameters.AddWithValue(param[12].ToString(), param[28].ToString());
kmt16.Parameters.AddWithValue(param[13].ToString(), param[29].ToString());
kmt16.Parameters.AddWithValue(param[14].ToString(), param[30].ToString());
kmt16.Parameters.AddWithValue(param[15].ToString(), param[31].ToString());
kmt16.Parameters.AddWithValue(param[16].ToString(), param[32].ToString());
kmt16.ExecuteNonQuery();

                        break;
                    case "17":
                   
SqlCommand kmt17 = new SqlCommand(param[0].ToString(), con);
kmt17.CommandType = CommandType.StoredProcedure;
kmt17.Parameters.AddWithValue(param[1].ToString(), param[18].ToString());
kmt17.Parameters.AddWithValue(param[2].ToString(), param[19].ToString());
kmt17.Parameters.AddWithValue(param[3].ToString(), param[20].ToString());
kmt17.Parameters.AddWithValue(param[4].ToString(), param[21].ToString());
kmt17.Parameters.AddWithValue(param[5].ToString(), param[22].ToString());
kmt17.Parameters.AddWithValue(param[6].ToString(), param[23].ToString());
kmt17.Parameters.AddWithValue(param[7].ToString(), param[24].ToString());
kmt17.Parameters.AddWithValue(param[8].ToString(), param[25].ToString());
kmt17.Parameters.AddWithValue(param[9].ToString(), param[26].ToString());
kmt17.Parameters.AddWithValue(param[10].ToString(), param[27].ToString());
kmt17.Parameters.AddWithValue(param[11].ToString(), param[28].ToString());
kmt17.Parameters.AddWithValue(param[12].ToString(), param[29].ToString());
kmt17.Parameters.AddWithValue(param[13].ToString(), param[30].ToString());
kmt17.Parameters.AddWithValue(param[14].ToString(), param[31].ToString());
kmt17.Parameters.AddWithValue(param[15].ToString(), param[32].ToString());
kmt17.Parameters.AddWithValue(param[16].ToString(), param[33].ToString());
kmt17.Parameters.AddWithValue(param[17].ToString(), param[34].ToString());
kmt17.ExecuteNonQuery();

                        break;
                    case "18":
                       
SqlCommand kmt18 = new SqlCommand(param[0].ToString(), con);
kmt18.CommandType = CommandType.StoredProcedure;
kmt18.Parameters.AddWithValue(param[1].ToString(), param[19].ToString());
kmt18.Parameters.AddWithValue(param[2].ToString(), param[20].ToString());
kmt18.Parameters.AddWithValue(param[3].ToString(), param[21].ToString());
kmt18.Parameters.AddWithValue(param[4].ToString(), param[22].ToString());
kmt18.Parameters.AddWithValue(param[5].ToString(), param[23].ToString());
kmt18.Parameters.AddWithValue(param[6].ToString(), param[24].ToString());
kmt18.Parameters.AddWithValue(param[7].ToString(), param[25].ToString());
kmt18.Parameters.AddWithValue(param[8].ToString(), param[26].ToString());
kmt18.Parameters.AddWithValue(param[9].ToString(), param[27].ToString());
kmt18.Parameters.AddWithValue(param[10].ToString(), param[28].ToString());
kmt18.Parameters.AddWithValue(param[11].ToString(), param[29].ToString());
kmt18.Parameters.AddWithValue(param[12].ToString(), param[30].ToString());
kmt18.Parameters.AddWithValue(param[13].ToString(), param[31].ToString());
kmt18.Parameters.AddWithValue(param[14].ToString(), param[32].ToString());
kmt18.Parameters.AddWithValue(param[15].ToString(), param[33].ToString());
kmt18.Parameters.AddWithValue(param[16].ToString(), param[34].ToString());
kmt18.Parameters.AddWithValue(param[17].ToString(), param[35].ToString());
kmt18.Parameters.AddWithValue(param[18].ToString(), param[36].ToString());
kmt18.ExecuteNonQuery();

                        break;
                    case "19":
                     
SqlCommand kmt19 = new SqlCommand(param[0].ToString(), con);
kmt19.CommandType = CommandType.StoredProcedure;
kmt19.Parameters.AddWithValue(param[1].ToString(), param[20].ToString());
kmt19.Parameters.AddWithValue(param[2].ToString(), param[21].ToString());
kmt19.Parameters.AddWithValue(param[3].ToString(), param[22].ToString());
kmt19.Parameters.AddWithValue(param[4].ToString(), param[23].ToString());
kmt19.Parameters.AddWithValue(param[5].ToString(), param[24].ToString());
kmt19.Parameters.AddWithValue(param[6].ToString(), param[25].ToString());
kmt19.Parameters.AddWithValue(param[7].ToString(), param[26].ToString());
kmt19.Parameters.AddWithValue(param[8].ToString(), param[27].ToString());
kmt19.Parameters.AddWithValue(param[9].ToString(), param[28].ToString());
kmt19.Parameters.AddWithValue(param[10].ToString(), param[29].ToString());
kmt19.Parameters.AddWithValue(param[11].ToString(), param[30].ToString());
kmt19.Parameters.AddWithValue(param[12].ToString(), param[31].ToString());
kmt19.Parameters.AddWithValue(param[13].ToString(), param[32].ToString());
kmt19.Parameters.AddWithValue(param[14].ToString(), param[33].ToString());
kmt19.Parameters.AddWithValue(param[15].ToString(), param[34].ToString());
kmt19.Parameters.AddWithValue(param[16].ToString(), param[35].ToString());
kmt19.Parameters.AddWithValue(param[17].ToString(), param[36].ToString());
kmt19.Parameters.AddWithValue(param[18].ToString(), param[37].ToString());
kmt19.Parameters.AddWithValue(param[19].ToString(), param[38].ToString());
kmt19.ExecuteNonQuery();
                        break;
                    case "20":
              SqlCommand kmt20 = new SqlCommand(param[0].ToString(), con);
kmt20.CommandType = CommandType.StoredProcedure;
kmt20.Parameters.AddWithValue(param[1].ToString(), param[21].ToString());
kmt20.Parameters.AddWithValue(param[2].ToString(), param[22].ToString());
kmt20.Parameters.AddWithValue(param[3].ToString(), param[23].ToString());
kmt20.Parameters.AddWithValue(param[4].ToString(), param[24].ToString());
kmt20.Parameters.AddWithValue(param[5].ToString(), param[25].ToString());
kmt20.Parameters.AddWithValue(param[6].ToString(), param[26].ToString());
kmt20.Parameters.AddWithValue(param[7].ToString(), param[27].ToString());
kmt20.Parameters.AddWithValue(param[8].ToString(), param[28].ToString());
kmt20.Parameters.AddWithValue(param[9].ToString(), param[29].ToString());
kmt20.Parameters.AddWithValue(param[10].ToString(), param[30].ToString());
kmt20.Parameters.AddWithValue(param[11].ToString(), param[31].ToString());
kmt20.Parameters.AddWithValue(param[12].ToString(), param[32].ToString());
kmt20.Parameters.AddWithValue(param[13].ToString(), param[33].ToString());
kmt20.Parameters.AddWithValue(param[14].ToString(), param[34].ToString());
kmt20.Parameters.AddWithValue(param[15].ToString(), param[35].ToString());
kmt20.Parameters.AddWithValue(param[16].ToString(), param[36].ToString());
kmt20.Parameters.AddWithValue(param[17].ToString(), param[37].ToString());
kmt20.Parameters.AddWithValue(param[18].ToString(), param[38].ToString());
kmt20.Parameters.AddWithValue(param[19].ToString(), param[39].ToString());
kmt20.Parameters.AddWithValue(param[20].ToString(), param[40].ToString());
kmt20.ExecuteNonQuery();

                        break;
                    default:
                        break;
                }
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,gm .ToString ());
            }
        }
        public void sp_ek(string cml,params string[] param)
        {
            try
            {
 SqlConnection con = baglanti_open();
            switch (cml)
            {
                case "1":
                      SqlCommand kmt = new SqlCommand(param[0].ToString(), con);
                    kmt.CommandType = CommandType.StoredProcedure;
                    kmt.Parameters.AddWithValue(param[1].ToString(), param[2].ToString());
                    int sonuc = kmt.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                        
                    }
                    else if (sonuc == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         
                    
                    break;
                case "2":
                      SqlCommand kmt1 = new SqlCommand(param[0].ToString(), con);
                      kmt1.CommandType = CommandType.StoredProcedure;
                      kmt1.Parameters.AddWithValue(param[1].ToString(), param[3].ToString());
                      kmt1.Parameters.AddWithValue(param[2].ToString(), param[4].ToString());
                    int sonuc1 = kmt1.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc1 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc1 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         
                 
                    break;
                case "3":
                      SqlCommand kmt2 = new SqlCommand(param[0].ToString(), con);
                    kmt2.CommandType = CommandType.StoredProcedure;
                    kmt2.Parameters.AddWithValue(param[1].ToString(), param[4].ToString());
                    kmt2.Parameters.AddWithValue(param[2].ToString(), param[5].ToString());
                    kmt2.Parameters.AddWithValue(param[3].ToString(), param[6].ToString());
                    int sonuc2 = kmt2.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc2 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc2 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "4":
                      SqlCommand kmt3 = new SqlCommand(param[0].ToString(), con);
                      kmt3.CommandType = CommandType.StoredProcedure;
                      kmt3.Parameters.AddWithValue(param[1].ToString(), param[5].ToString());
                      kmt3.Parameters.AddWithValue(param[2].ToString(), param[6].ToString());
                      kmt3.Parameters.AddWithValue(param[3].ToString(), param[7].ToString());
                      kmt3.Parameters.AddWithValue(param[4].ToString(), param[8].ToString());
                      int sonuc3 = kmt3.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc3 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc3 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "5":
                    SqlCommand kmt4 = new SqlCommand(param[0].ToString(), con);
                    kmt4.CommandType = CommandType.StoredProcedure;
                    kmt4.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                    kmt4.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                    kmt4.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
                    kmt4.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
                    kmt4.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                    int sonuc4 = kmt4.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc4 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc4 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         
                    break;
                   case "6":
                      SqlCommand kmt5 = new SqlCommand(param[0].ToString(), con);
                      kmt5.CommandType = CommandType.StoredProcedure;
                      kmt5.Parameters.AddWithValue(param[1].ToString(), param[7].ToString());
                      kmt5.Parameters.AddWithValue(param[2].ToString(), param[8].ToString());
                      kmt5.Parameters.AddWithValue(param[3].ToString(), param[9].ToString());
                      kmt5.Parameters.AddWithValue(param[4].ToString(), param[10].ToString());
                      kmt5.Parameters.AddWithValue(param[5].ToString(), param[11].ToString());
                      kmt5.Parameters.AddWithValue(param[6].ToString(), param[12].ToString());
                      int sonuc5 = kmt5.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc5 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc5 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }
                      break;
                case "7":
                      SqlCommand kmt6 = new SqlCommand(param[0].ToString(), con);
                      kmt6.CommandType = CommandType.StoredProcedure;
                      kmt6.Parameters.AddWithValue(param[1].ToString(), param[8].ToString());
                      kmt6.Parameters.AddWithValue(param[2].ToString(), param[9].ToString());
                      kmt6.Parameters.AddWithValue(param[3].ToString(), param[10].ToString());
                      kmt6.Parameters.AddWithValue(param[4].ToString(), param[11].ToString());
                      kmt6.Parameters.AddWithValue(param[5].ToString(), param[12].ToString());
                      kmt6.Parameters.AddWithValue(param[6].ToString(), param[13].ToString());
                      kmt6.Parameters.AddWithValue(param[7].ToString(), param[14].ToString());
                      int sonuc6 = kmt6.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc6 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc6 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "8":
                      SqlCommand kmt7 = new SqlCommand(param[0].ToString(), con);
                      kmt7.CommandType = CommandType.StoredProcedure;
                      kmt7.Parameters.AddWithValue(param[1].ToString(), param[9].ToString());
                      kmt7.Parameters.AddWithValue(param[2].ToString(), param[10].ToString());
                      kmt7.Parameters.AddWithValue(param[3].ToString(), param[11].ToString());
                      kmt7.Parameters.AddWithValue(param[4].ToString(), param[12].ToString());
                      kmt7.Parameters.AddWithValue(param[5].ToString(), param[13].ToString());
                      kmt7.Parameters.AddWithValue(param[6].ToString(), param[14].ToString());
                      kmt7.Parameters.AddWithValue(param[7].ToString(), param[15].ToString());
                      kmt7.Parameters.AddWithValue(param[8].ToString(), param[16].ToString());
                      int sonuc7 = kmt7.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc7 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc7 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "9":
                      SqlCommand kmt8 = new SqlCommand(param[0].ToString(), con);
                      kmt8.CommandType = CommandType.StoredProcedure;
                      kmt8.Parameters.AddWithValue(param[1].ToString(), param[10].ToString());
                      kmt8.Parameters.AddWithValue(param[2].ToString(), param[11].ToString());
                      kmt8.Parameters.AddWithValue(param[3].ToString(), param[12].ToString());
                      kmt8.Parameters.AddWithValue(param[4].ToString(), param[13].ToString());
                      kmt8.Parameters.AddWithValue(param[5].ToString(), param[14].ToString());
                      kmt8.Parameters.AddWithValue(param[6].ToString(), param[15].ToString());
                      kmt8.Parameters.AddWithValue(param[7].ToString(), param[16].ToString());
                      kmt8.Parameters.AddWithValue(param[8].ToString(), param[17].ToString());
                      kmt8.Parameters.AddWithValue(param[9].ToString(), param[18].ToString());
                      int sonuc8 = kmt8.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc8 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc8 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "10":
                      SqlCommand kmt9 = new SqlCommand(param[0].ToString(), con);
                      kmt9.CommandType = CommandType.StoredProcedure;
                      kmt9.Parameters.AddWithValue(param[1].ToString(), param[11].ToString());
                      kmt9.Parameters.AddWithValue(param[2].ToString(), param[12].ToString());
                      kmt9.Parameters.AddWithValue(param[3].ToString(), param[13].ToString());
                      kmt9.Parameters.AddWithValue(param[4].ToString(), param[14].ToString());
                      kmt9.Parameters.AddWithValue(param[5].ToString(), param[15].ToString());
                      kmt9.Parameters.AddWithValue(param[6].ToString(), param[16].ToString());
                      kmt9.Parameters.AddWithValue(param[7].ToString(), param[17].ToString());
                      kmt9.Parameters.AddWithValue(param[8].ToString(), param[18].ToString());
                      kmt9.Parameters.AddWithValue(param[9].ToString(), param[19].ToString());
                      kmt9.Parameters.AddWithValue(param[10].ToString(), param[20].ToString());
                      int sonuc9 = kmt9.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc9 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc9 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "11":
                      SqlCommand kmt10 = new SqlCommand(param[0].ToString(), con);
                      kmt10.CommandType = CommandType.StoredProcedure;
                      kmt10.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                      kmt10.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                      kmt10.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
                    kmt10.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
                    kmt10.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                      kmt10.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                      kmt10.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                      kmt10.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
                    kmt10.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
                    kmt10.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                    kmt10.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                    int sonuc10 = kmt10.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc10 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc10 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "12":
                      SqlCommand kmt11 = new SqlCommand(param[0].ToString(), con);
                      kmt11.CommandType = CommandType.StoredProcedure;
                      kmt11.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                      kmt11.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                      kmt11.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
                      kmt11.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
                      kmt11.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                      kmt11.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                      kmt11.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                      kmt11.Parameters.AddWithValue(param[3].ToString(), param[8].ToString());
                      kmt11.Parameters.AddWithValue(param[4].ToString(), param[9].ToString());
                      kmt11.Parameters.AddWithValue(param[5].ToString(), param[10].ToString());
                      kmt11.Parameters.AddWithValue(param[1].ToString(), param[6].ToString());
                      kmt11.Parameters.AddWithValue(param[2].ToString(), param[7].ToString());
                   
                      int sonuc11 = kmt11.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc11 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc11 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "13":
                      SqlCommand kmt12 = new SqlCommand(param[0].ToString(), con);
                      kmt12.CommandType = CommandType.StoredProcedure;
                      kmt12.CommandType = CommandType.StoredProcedure;
                      kmt12.Parameters.AddWithValue(param[1].ToString(), param[14].ToString());
                      kmt12.Parameters.AddWithValue(param[2].ToString(), param[15].ToString());
                      kmt12.Parameters.AddWithValue(param[3].ToString(), param[16].ToString());
                      kmt12.Parameters.AddWithValue(param[4].ToString(), param[17].ToString());
                      kmt12.Parameters.AddWithValue(param[5].ToString(), param[18].ToString());
                      kmt12.Parameters.AddWithValue(param[6].ToString(), param[19].ToString());
                      kmt12.Parameters.AddWithValue(param[7].ToString(), param[20].ToString());
                      kmt12.Parameters.AddWithValue(param[8].ToString(), param[21].ToString());
                      kmt12.Parameters.AddWithValue(param[9].ToString(), param[22].ToString());
                      kmt12.Parameters.AddWithValue(param[10].ToString(), param[23].ToString());
                      kmt12.Parameters.AddWithValue(param[11].ToString(), param[24].ToString());
                      kmt12.Parameters.AddWithValue(param[12].ToString(), param[25].ToString());
                      kmt12.Parameters.AddWithValue(param[13].ToString(), param[26].ToString());
                
                      int sonuc12 = kmt12.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc12 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc12 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "14":
                      SqlCommand kmt13 = new SqlCommand(param[0].ToString(), con);
                      kmt13.CommandType = CommandType.StoredProcedure;
                      kmt13.Parameters.AddWithValue(param[1].ToString(), param[15].ToString());
                      kmt13.Parameters.AddWithValue(param[2].ToString(), param[16].ToString());
                      kmt13.Parameters.AddWithValue(param[3].ToString(), param[17].ToString());
                      kmt13.Parameters.AddWithValue(param[4].ToString(), param[18].ToString());
                      kmt13.Parameters.AddWithValue(param[5].ToString(), param[19].ToString());
                      kmt13.Parameters.AddWithValue(param[6].ToString(), param[20].ToString());
                      kmt13.Parameters.AddWithValue(param[7].ToString(), param[21].ToString());
                      kmt13.Parameters.AddWithValue(param[8].ToString(), param[22].ToString());
                      kmt13.Parameters.AddWithValue(param[9].ToString(), param[23].ToString());
                      kmt13.Parameters.AddWithValue(param[10].ToString(), param[24].ToString());
                      kmt13.Parameters.AddWithValue(param[11].ToString(), param[25].ToString());
                      kmt13.Parameters.AddWithValue(param[12].ToString(), param[26].ToString());
                      kmt13.Parameters.AddWithValue(param[13].ToString(), param[27].ToString());
                      kmt13.Parameters.AddWithValue(param[14].ToString(), param[28].ToString());            
                    int sonuc13 = kmt13.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc13 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc13 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "15":
                      SqlCommand kmt14 = new SqlCommand(param[0].ToString(), con);
                      kmt14.CommandType = CommandType.StoredProcedure;
                      kmt14.Parameters.AddWithValue(param[1].ToString(), param[16].ToString());
                      kmt14.Parameters.AddWithValue(param[2].ToString(), param[17].ToString());
                      kmt14.Parameters.AddWithValue(param[3].ToString(), param[18].ToString());
                      kmt14.Parameters.AddWithValue(param[4].ToString(), param[19].ToString());
                      kmt14.Parameters.AddWithValue(param[5].ToString(), param[20].ToString());
                      kmt14.Parameters.AddWithValue(param[6].ToString(), param[21].ToString());
                      kmt14.Parameters.AddWithValue(param[7].ToString(), param[22].ToString());
                      kmt14.Parameters.AddWithValue(param[8].ToString(), param[23].ToString());
                      kmt14.Parameters.AddWithValue(param[9].ToString(), param[24].ToString());
                      kmt14.Parameters.AddWithValue(param[10].ToString(), param[25].ToString());
                      kmt14.Parameters.AddWithValue(param[11].ToString(), param[26].ToString());
                      kmt14.Parameters.AddWithValue(param[12].ToString(), param[27].ToString());
                      kmt14.Parameters.AddWithValue(param[13].ToString(), param[28].ToString());
                      kmt14.Parameters.AddWithValue(param[14].ToString(), param[29].ToString());
                      kmt14.Parameters.AddWithValue(param[15].ToString(), param[30].ToString()); 
                    int sonuc14 = kmt14.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc14 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc14 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "16":
                    SqlCommand kmt15 = new SqlCommand(param[0].ToString(), con);
                    kmt15.CommandType = CommandType.StoredProcedure;
                    kmt15.Parameters.AddWithValue(param[1].ToString(), param[17].ToString());
                    kmt15.Parameters.AddWithValue(param[2].ToString(), param[18].ToString());
                    kmt15.Parameters.AddWithValue(param[3].ToString(), param[19].ToString());
                    kmt15.Parameters.AddWithValue(param[4].ToString(), param[20].ToString());
                    kmt15.Parameters.AddWithValue(param[5].ToString(), param[21].ToString());
                    kmt15.Parameters.AddWithValue(param[6].ToString(), param[22].ToString());
                    kmt15.Parameters.AddWithValue(param[7].ToString(), param[23].ToString());
                    kmt15.Parameters.AddWithValue(param[8].ToString(), param[24].ToString());
                    kmt15.Parameters.AddWithValue(param[9].ToString(), param[25].ToString());
                    kmt15.Parameters.AddWithValue(param[10].ToString(), param[26].ToString());
                    kmt15.Parameters.AddWithValue(param[11].ToString(), param[27].ToString());
                    kmt15.Parameters.AddWithValue(param[12].ToString(), param[28].ToString());
                    kmt15.Parameters.AddWithValue(param[13].ToString(), param[29].ToString());
                    kmt15.Parameters.AddWithValue(param[14].ToString(), param[30].ToString());
                    kmt15.Parameters.AddWithValue(param[15].ToString(), param[31].ToString()); 
                    kmt15.Parameters.AddWithValue(param[16].ToString(), param[32].ToString());
                    int sonuc15 = kmt15.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                    if (sonuc15 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                    else if (sonuc15 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "17":
                      SqlCommand kmt16 = new SqlCommand(param[0].ToString(), con);
                      kmt16.CommandType = CommandType.StoredProcedure;
                      kmt16.Parameters.AddWithValue(param[1].ToString(), param[18].ToString());
                      kmt16.Parameters.AddWithValue(param[2].ToString(), param[19].ToString());
                      kmt16.Parameters.AddWithValue(param[3].ToString(), param[20].ToString());
                      kmt16.Parameters.AddWithValue(param[4].ToString(), param[21].ToString());
                      kmt16.Parameters.AddWithValue(param[5].ToString(), param[22].ToString());
                      kmt16.Parameters.AddWithValue(param[6].ToString(), param[23].ToString());
                      kmt16.Parameters.AddWithValue(param[7].ToString(), param[24].ToString());
                      kmt16.Parameters.AddWithValue(param[8].ToString(), param[25].ToString());
                      kmt16.Parameters.AddWithValue(param[9].ToString(), param[26].ToString());
                      kmt16.Parameters.AddWithValue(param[10].ToString(), param[27].ToString());
                      kmt16.Parameters.AddWithValue(param[11].ToString(), param[28].ToString());
                      kmt16.Parameters.AddWithValue(param[12].ToString(), param[29].ToString());
                      kmt16.Parameters.AddWithValue(param[13].ToString(), param[30].ToString());
                      kmt16.Parameters.AddWithValue(param[14].ToString(), param[31].ToString());
                      kmt16.Parameters.AddWithValue(param[15].ToString(), param[32].ToString());
                      kmt16.Parameters.AddWithValue(param[16].ToString(), param[33].ToString());
                      kmt16.Parameters.AddWithValue(param[17].ToString(), param[34].ToString());
                      int sonuc16 = kmt16.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc16 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc16 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "18":
                      SqlCommand kmt17 = new SqlCommand(param[0].ToString(), con);
                      kmt17.CommandType = CommandType.StoredProcedure;
                      kmt17.Parameters.AddWithValue(param[1].ToString(), param[19].ToString());
                      kmt17.Parameters.AddWithValue(param[2].ToString(), param[20].ToString());
                      kmt17.Parameters.AddWithValue(param[3].ToString(), param[21].ToString());
                      kmt17.Parameters.AddWithValue(param[4].ToString(), param[22].ToString());
                      kmt17.Parameters.AddWithValue(param[5].ToString(), param[23].ToString());
                      kmt17.Parameters.AddWithValue(param[6].ToString(), param[24].ToString());
                      kmt17.Parameters.AddWithValue(param[7].ToString(), param[25].ToString());
                      kmt17.Parameters.AddWithValue(param[8].ToString(), param[26].ToString());
                      kmt17.Parameters.AddWithValue(param[9].ToString(), param[27].ToString());
                      kmt17.Parameters.AddWithValue(param[10].ToString(), param[28].ToString());
                      kmt17.Parameters.AddWithValue(param[11].ToString(), param[29].ToString());
                      kmt17.Parameters.AddWithValue(param[12].ToString(), param[30].ToString());
                      kmt17.Parameters.AddWithValue(param[13].ToString(), param[31].ToString());
                      kmt17.Parameters.AddWithValue(param[14].ToString(), param[32].ToString());
                      kmt17.Parameters.AddWithValue(param[15].ToString(), param[33].ToString());
                      kmt17.Parameters.AddWithValue(param[16].ToString(), param[34].ToString());
                      kmt17.Parameters.AddWithValue(param[17].ToString(), param[35].ToString());
                      kmt17.Parameters.AddWithValue(param[18].ToString(), param[36].ToString());
                   
                      int sonuc17 = kmt17.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc17 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc17 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "19":
                      SqlCommand kmt18 = new SqlCommand(param[0].ToString(), con);
                      kmt18.CommandType = CommandType.StoredProcedure;
                      kmt18.Parameters.AddWithValue(param[1].ToString(), param[20].ToString());
                      kmt18.Parameters.AddWithValue(param[2].ToString(), param[21].ToString());
                      kmt18.Parameters.AddWithValue(param[3].ToString(), param[22].ToString());
                      kmt18.Parameters.AddWithValue(param[4].ToString(), param[23].ToString());
                      kmt18.Parameters.AddWithValue(param[5].ToString(), param[24].ToString());
                      kmt18.Parameters.AddWithValue(param[6].ToString(), param[25].ToString());
                      kmt18.Parameters.AddWithValue(param[7].ToString(), param[26].ToString());
                      kmt18.Parameters.AddWithValue(param[8].ToString(), param[27].ToString());
                      kmt18.Parameters.AddWithValue(param[9].ToString(), param[28].ToString());
                      kmt18.Parameters.AddWithValue(param[10].ToString(), param[29].ToString());
                      kmt18.Parameters.AddWithValue(param[11].ToString(), param[30].ToString());
                      kmt18.Parameters.AddWithValue(param[12].ToString(), param[31].ToString());
                      kmt18.Parameters.AddWithValue(param[13].ToString(), param[32].ToString());
                      kmt18.Parameters.AddWithValue(param[14].ToString(), param[33].ToString());
                      kmt18.Parameters.AddWithValue(param[15].ToString(), param[34].ToString());
                      kmt18.Parameters.AddWithValue(param[16].ToString(), param[35].ToString());
                      kmt18.Parameters.AddWithValue(param[17].ToString(), param[36].ToString());
                      kmt18.Parameters.AddWithValue(param[18].ToString(), param[37].ToString());
                      kmt18.Parameters.AddWithValue(param[19].ToString(), param[38].ToString());
                      int sonuc18 = kmt18.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc18 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc18 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                case "20":
                      SqlCommand kmt19 = new SqlCommand(param[0].ToString(), con);
                      kmt19.CommandType = CommandType.StoredProcedure;
                      kmt19.Parameters.AddWithValue(param[1].ToString(), param[20].ToString());
                      kmt19.Parameters.AddWithValue(param[2].ToString(), param[21].ToString());
                      kmt19.Parameters.AddWithValue(param[3].ToString(), param[22].ToString());
                      kmt19.Parameters.AddWithValue(param[4].ToString(), param[23].ToString());
                      kmt19.Parameters.AddWithValue(param[5].ToString(), param[24].ToString());
                      kmt19.Parameters.AddWithValue(param[6].ToString(), param[25].ToString());
                      kmt19.Parameters.AddWithValue(param[7].ToString(), param[26].ToString());
                      kmt19.Parameters.AddWithValue(param[8].ToString(), param[27].ToString());
                      kmt19.Parameters.AddWithValue(param[9].ToString(), param[28].ToString());
                      kmt19.Parameters.AddWithValue(param[10].ToString(), param[29].ToString());
                      kmt19.Parameters.AddWithValue(param[11].ToString(), param[30].ToString());
                      kmt19.Parameters.AddWithValue(param[12].ToString(), param[31].ToString());
                      kmt19.Parameters.AddWithValue(param[13].ToString(), param[32].ToString());
                      kmt19.Parameters.AddWithValue(param[14].ToString(), param[33].ToString());
                      kmt19.Parameters.AddWithValue(param[15].ToString(), param[34].ToString());
                      kmt19.Parameters.AddWithValue(param[16].ToString(), param[35].ToString());
                      kmt19.Parameters.AddWithValue(param[17].ToString(), param[36].ToString());
                      kmt19.Parameters.AddWithValue(param[18].ToString(), param[37].ToString());
                      kmt19.Parameters.AddWithValue(param[19].ToString(), param[38].ToString());
                      kmt19.Parameters.AddWithValue(param[19].ToString(), param[38].ToString());
                      int sonuc19 = kmt19.ExecuteNonQuery();
                    //m.mesajlar(sonuc.ToString ());
                      if (sonuc19 == -1)
                    {
                       MessageBox .Show (gm_4, gm);
                        con.Close();
                    }
                      else if (sonuc19 == 1)
                    {
                       MessageBox .Show (gm_1, gm);
                        con.Close();
                    }         

                    break;
                default:
                    break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,gm.ToString ());
            }
        }
        public void sp_k_grs(string cml, params string[] param)
        {
            SqlConnection con = baglanti_open();
            switch (cml)
            {
                case "4":
                    SqlCommand kmt3 = new SqlCommand(param[0].ToString(), con);
                    kmt3.CommandType = CommandType.StoredProcedure;
                    kmt3.Parameters.AddWithValue(param[1].ToString(), param[5].ToString());
                    kmt3.Parameters.AddWithValue(param[2].ToString(), param[6].ToString());
                    kmt3.Parameters.AddWithValue(param[3].ToString(), param[7].ToString());
                    kmt3.Parameters.AddWithValue(param[4].ToString(), param[8].ToString());
                    int sonuc3 = kmt3.ExecuteNonQuery();
                    if (sonuc3 == -1)
                    {
                        grs_drm = 0;
                        MessageBox.Show("Lütfen Bilgileri Kontrol ediniz", gm);
                        con.Close();
                    }
                    else if (sonuc3 == 1)
                    {
                        grs_drm = 1;
                        MessageBox.Show("Giriş İşlemi Başarılı", gm);
                        con.Close();
                    }
                    break;
                default:
                    break;
            }
        }
        public DataTable Tablo(string sqlCumlem, DataGridView veridatagrid)
        {
            using (SqlConnection con = baglanti_open ())
            {
                SqlDataAdapter adap = new SqlDataAdapter(sqlCumlem, con);
                DataTable dt = new DataTable();
                try
                {
                    adap.Fill(dt);
                    veridatagrid.DataSource = dt;

                }
                catch (Exception ex)
                {
                   MessageBox .Show (ex.Message, gm);
                }
                adap.Dispose();
                return dt;
            }

        }
        public SqlDataReader Reader3(string sqlcumle, ComboBox combo ,string s )
        {
            SqlCommand komut = new SqlCommand("" + sqlcumle + "",baglanti_open ());
            SqlDataReader rdr = komut.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    combo.Items.Add(rdr[s].ToString ());
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,gm.ToString ());
            }
            rdr.Dispose();
            baglanti_close();
            return rdr;
          }
        }
    }

