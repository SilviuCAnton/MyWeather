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
    public sealed partial class S2_P3 : Page
    {
        public S2_P3()
        {
            this.InitializeComponent();
            ImagineFundal.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/fitnessjog.jpg"));
        }

        private void Bulina1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImagineFundal.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/sport.jpg"));
        }

        private void Bulina2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImagineFundal.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/ceaiuri.jpg"));
        }

        private void Bulina3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImagineFundal.Source = new BitmapImage(new Uri(this.BaseUri, "../Assets/Imagini/vitamine.jpg"));
        }
    }
}
