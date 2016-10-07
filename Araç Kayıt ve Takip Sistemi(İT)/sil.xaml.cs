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
using System.Windows.Shapes;

namespace Araç_Kayıt_ve_Takip_Sistemi_İT_
{
	/// <summary>
	/// Interaction logic for sil.xaml
	/// </summary>
	public partial class sil : Window
	{
		public sil()
		{
			this.InitializeComponent();
            gtr();
		}
        kayit_islemleri k = new kayit_islemleri();
        void gtr()
        {
            k.Tablo("select *  from it_topdanci_blglr", gr_gridview);

        }
		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.DragMove ();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

	}
}