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

namespace MyWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S1_P3 : Page
    {
        public S1_P3()
        {
            this.InitializeComponent();
            TextBlockFeedback.Text = "";
        }

        private void ButonTrimiteAlegeri_Click(object sender, RoutedEventArgs e)
        {
            ImagineFeedback1.Visibility = Visibility.Collapsed;
            ImagineFeedback2.Visibility = Visibility.Collapsed;
            ImagineFeedback3.Visibility = Visibility.Collapsed;
            ImagineFeedback4.Visibility = Visibility.Collapsed;

            if (CheckBox4.IsChecked == true)
            {
                TextBlockFeedback.Foreground = new SolidColorBrush(Color.FromArgb(255, 157, 55, 17));
                TextBlockFeedback.Text = "Mai incearca! (Ai bifat cel putin o optiune gresita.)";

                ImagineFeedback4.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/x.png"));
                ImagineFeedback4.Visibility = Visibility.Visible;

                if (CheckBox1.IsChecked == true)
                {
                    ImagineFeedback1.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback1.Visibility = Visibility.Visible;
                }

                if (CheckBox2.IsChecked == true)
                {
                    ImagineFeedback2.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback2.Visibility = Visibility.Visible;
                }

                if (CheckBox3.IsChecked == true)
                {
                    ImagineFeedback3.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback3.Visibility = Visibility.Visible;
                }
            }

            else if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true && CheckBox3.IsChecked == true)
            {
                TextBlockFeedback.Foreground = new SolidColorBrush(Color.FromArgb(255, 74, 140, 15));
                TextBlockFeedback.Text = "Bravo, raspunsul tau este corect! (Ai bifat toate raspunsurile corecte.)";

                ImagineFeedback1.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback1.Visibility = Visibility.Visible;

                ImagineFeedback2.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback2.Visibility = Visibility.Visible;

                ImagineFeedback3.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                ImagineFeedback3.Visibility = Visibility.Visible;
            }

            else
            {
                TextBlockFeedback.Foreground = new SolidColorBrush(Color.FromArgb(255, 157, 55, 17));
                TextBlockFeedback.Text = "Mai incearca! (Nu ai bifat toate raspunsurile corecte)";

                if (CheckBox1.IsChecked == true)
                {
                    ImagineFeedback1.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback1.Visibility = Visibility.Visible;
                }

                if (CheckBox2.IsChecked == true)
                {
                    ImagineFeedback2.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback2.Visibility = Visibility.Visible;
                }

                if (CheckBox3.IsChecked == true)
                {
                    ImagineFeedback3.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/bifa.png"));
                    ImagineFeedback3.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
