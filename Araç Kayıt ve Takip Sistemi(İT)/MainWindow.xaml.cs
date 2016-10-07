using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Araç_Kayıt_ve_Takip_Sistemi_İT_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gtr();
        }
        kayit_islemleri k = new kayit_islemleri();
        void gtr()
        {
            k.Reader3("select * from frm_blglr", cmb_gls_ndn , "frm_adi");
        }
        private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this.DragMove ();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close ();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            k.sp_ek("6", "sp_it_topdanci_blglr_save", "@brkt_nmr", "@src_adi", "@arac_cinsi", "@pilaka_no","calistigi_frm", "@gelis_nedeni",
                                                      txt_pilaka.Text ,txt_src_adi .Text ,txt_arc_cns .Text ,txt_plak_no .Text ,txt_clsth_frm .Text ,cmb_gls_ndn .Text );
        }
    }
}
