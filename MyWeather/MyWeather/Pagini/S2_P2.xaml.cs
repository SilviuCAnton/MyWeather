using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWeather.Pagini
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S2_P2 : Page
    {
        public S2_P2()
        {
            this.InitializeComponent();
            TexblockIntampinare.Text = Meniu.numeUtilizator + ", ce spui? Care dintre efectele starii meteo asupra psihicului ti se aplica?";
            TextBlockRezultat.Visibility = Visibility.Collapsed;
        }

        private void ButonTrimiteAlegeri_Click(object sender, RoutedEventArgs e)
        {
            if (Checkbox1.IsChecked == true || Checkbox2.IsChecked == true || Checkbox3.IsChecked == true) 
                TextBlockRezultat.Visibility = Visibility.Visible;
        }
    }
}
