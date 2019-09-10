using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class S2_P4 : Page
    {
        public S2_P4()
        {
            this.InitializeComponent();
        }

        private void ButonTrimiteAlegeri_Click(object sender, RoutedEventArgs e)
        {
            ImagineFeedback1.Visibility = Visibility.Collapsed;
            ImagineFeedback2.Visibility = Visibility.Collapsed;
            ImagineFeedback3.Visibility = Visibility.Collapsed;

            if (Checkbox1.IsChecked == true && Checkbox2.IsChecked == true && Checkbox3.IsChecked == true)
            {
                TextBlockRezultat.Foreground = new SolidColorBrush(Color.FromArgb(255, 74, 140, 15));
                TextBlockRezultat.Text = "Bravo, raspunsul tau este corect! (Ai bifat toate raspunsurile corecte.)";

                ImagineFeedback1.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback1.Visibility = Visibility.Visible;

                ImagineFeedback2.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback2.Visibility = Visibility.Visible;

                ImagineFeedback3.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback3.Visibility = Visibility.Visible;
            }

            else
            {
                TextBlockRezultat.Foreground = new SolidColorBrush(Color.FromArgb(255, 157, 55, 17));
                TextBlockRezultat.Text = "Mai incearca! (Nu ai bifat toate raspunsurile corecte)";

                if (Checkbox1.IsChecked == true)
                {
                    ImagineFeedback1.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback1.Visibility = Visibility.Visible;
                }

                if (Checkbox2.IsChecked == true)
                {
                    ImagineFeedback2.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback2.Visibility = Visibility.Visible;
                }

                if (Checkbox3.IsChecked == true)
                {
                    ImagineFeedback3.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback3.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
