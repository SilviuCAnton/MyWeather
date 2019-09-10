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

namespace MyWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S1_P2 : Page
    {
        public S1_P2()
        {
            this.InitializeComponent();

            TextblockIntampinare.Text = "Ei bine, " + Meniu.numeUtilizator + ", aste e vremea care se potriveste starii tale de acum!";

            if (Meniu.numarDispozitie <= 4)
                ImagineStare.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/rea.jpg"));

            else if (Meniu.numarDispozitie >= 5 && Meniu.numarDispozitie <= 7)
                ImagineStare.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/buna.jpg"));

            else
                ImagineStare.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/foarte_buna.jpg"));
        }
    }
}
