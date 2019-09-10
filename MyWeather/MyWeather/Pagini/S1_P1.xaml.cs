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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S1_P1 : Page
    {
        public S1_P1()
        {
            this.InitializeComponent();
            int numar = 10;

            for(int i = 1; i<=numar; i++)
                ComboBoxDispozitie.Items.Add(i);
        }

        private async void ButonTrimiteAlegeri_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxNume.Text.ToString() != "" && TextBoxNume.Text != null && ComboBoxDispozitie.SelectedItem != null)
            {
                Meniu.numeUtilizator = TextBoxNume.Text.ToString();
                string str = ComboBoxDispozitie.SelectedItem.ToString();
                Int32.TryParse(str, out Meniu.numarDispozitie);
                ButonTrimiteAlegeri.IsEnabled = false;


                var x = (Frame)this.Parent;

                var xx = (Grid)x.Parent;

                var xxx = (StackPanel)xx.Children[2];

                var y = (Button)xxx.Children[1];

                y.IsEnabled = true;
                y.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
            }
            else
            {
                ContentDialog selectieIncompleta = new ContentDialog
                {
                    Title = "Atentie! Trebuie sa completezi ambele casete.",
                    Content = "Asigura-te ca ai completat campul nume si ca ai selectat un numar.",
                    CloseButtonText = "Continua"
                };

                ContentDialogResult result = await selectieIncompleta.ShowAsync();
            }
        }
    }
}
