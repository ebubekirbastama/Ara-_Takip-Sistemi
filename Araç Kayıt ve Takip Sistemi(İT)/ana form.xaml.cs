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
	/// Interaction logic for ana_form.xaml
	/// </summary>
	public partial class ana_form : Window
	{
		public ana_form()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.DragMove();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sil s = new sil();
            s.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            güncelle g = new güncelle();
            g.ShowDialog();
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
	}
}