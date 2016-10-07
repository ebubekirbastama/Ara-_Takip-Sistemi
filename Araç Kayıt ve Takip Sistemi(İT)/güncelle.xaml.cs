using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Araç_Kayıt_ve_Takip_Sistemi_İT_
{
	/// <summary>
	/// Interaction logic for güncelle.xaml
	/// </summary>
	public partial class güncelle : Window
	{
		public güncelle()
		{
			this.InitializeComponent();
            gtr();
		}
        kayit_islemleri k = new kayit_islemleri();
        baglanti bgl = new baglanti();
        void gtr()
        {
        	k.Tablo("select *  from it_topdanci_blglr", gr_gridview ); 
            
	    }
		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close ();// TODO: Add event handler implementation here.
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
	}
}