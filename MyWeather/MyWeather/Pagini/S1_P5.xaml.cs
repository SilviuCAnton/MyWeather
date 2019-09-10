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
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S1_P5 : Page
    {
        public S1_P5()
        {
            this.InitializeComponent();
            TextBlockRezultat.Text = "";
        }

        private void ButonTrimiteAlegeri_Click(object sender, RoutedEventArgs e)
        {
            if(ButonRadio1.IsChecked == true)
            {
                TextBlockRezultat.Foreground  = new SolidColorBrush(Color.FromArgb(255, 20, 197, 21));
                TextBlockRezultat.Text = "Super! Esti tipul meteoadaptabil!";
            }

            else if(ButonRadio2.IsChecked == true)
            {
                TextBlockRezultat.Foreground = new SolidColorBrush(Color.FromArgb(255, 20, 197, 21));
                TextBlockRezultat.Text = "Ai stiut? Esti tipul meteodependent!";
            }

            else if(ButonRadio3.IsChecked == true)
            {
                TextBlockRezultat.Foreground = new SolidColorBrush(Color.FromArgb(255, 20, 197, 21));
                TextBlockRezultat.Text = "Cum era de asteptat! Esti tipul anticipativ!";
            }

            else if(ButonRadio4.IsChecked == true)
            {
                TextBlockRezultat.Foreground = new SolidColorBrush(Color.FromArgb(255, 20, 197, 21));
                TextBlockRezultat.Text = "Ai deja boli? Esti tipul meteosensibil!";
            }

            else
            {
                Foreground = new SolidColorBrush(Color.FromArgb(255, 241, 89, 58));
                TextBlockRezultat.Text = "Nu ai selectat niciun raspuns!";
            }
        }
    }
}
