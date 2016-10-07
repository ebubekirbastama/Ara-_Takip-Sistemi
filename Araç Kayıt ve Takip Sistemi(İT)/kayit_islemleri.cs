using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Araç_Kayıt_ve_Takip_Sistemi_İT_
{
        class kayit_islemleri : baglanti
        {
            public DataTable Tablo(string sqlCumlem, DataGrid   veridatagrid)
            {
                using (SqlConnection con = baglanti_open())
                {
                    SqlDataAdapter adap = new SqlDataAdapter(sqlCumlem, con);
                    dt = new DataTable();
                    try
                    {
                        adap.Fill(dt);
                        veridatagrid.ItemsSource = dt.DefaultView;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, gm);
                    }
                    adap.Dispose();
                    return dt;
                }

            }
            public SqlDataReader Reader3(string sqlcumle, ComboBox combo, string s)
            {
                SqlCommand komut = new SqlCommand("" + sqlcumle + "", baglanti_open());
                SqlDataReader rdr = komut.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        combo.Items.Add(rdr[s].ToString());
                        combo.Text = combo.Items[0].ToString();
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
            public void sp_ek(string cml, params string[] param)
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();

                            }
                            else if (sonuc == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc1 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc2 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc3 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc4 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc5 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc6 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc7 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc8 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc9 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc10 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc11 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc12 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc13 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc14 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc15 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc16 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc17 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc18 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
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
                                MessageBox.Show(gm_4, gm);
                                con.Close();
                            }
                            else if (sonuc19 == 1)
                            {
                                MessageBox.Show(gm_1, gm);
                                con.Close();
                            }

                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, gm.ToString());
                }
            }
        }
}
