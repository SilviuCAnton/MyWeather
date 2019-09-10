using MyWeather.Pagini;
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
    public sealed partial class Meniu : Page
    {
        public Meniu()
        {
            this.InitializeComponent();
        }

        public static string numeUtilizator;

        public static int numarDispozitie;

        //Deschidere panou meniu
        private void ButonPrincipal_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        } 

        private void ListaMeniu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Functie buton iesire
            if (Exit.IsSelected)
                Application.Current.Exit();

            //Initializare sectiuni
            if(Item1.IsSelected)
            {
                Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                MyFrame.Navigate(typeof(S1_P1), null);
            }

            if (Item2.IsSelected)
            {
                Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                MyFrame.Navigate(typeof(S2_P1), null);
            }

            if (Item3.IsSelected)
            {
                Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                MyFrame.Navigate(typeof(S3_P1), null);
            }

            if(Item4.IsSelected)
            {
                Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));
                Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));
                Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));
                Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                MyFrame.Navigate(typeof(S4_P), null);
            }
        }

        //Schimbarea temei Zi/Noapte
        private void ButonTema_Click(object sender, RoutedEventArgs e)
        {
            if (RequestedTheme == ElementTheme.Default)
            {
                ButonTema.Content = "Tema Zi";
                RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                ButonTema.Content = "Tema Noapte";
                RequestedTheme = ElementTheme.Default;
            }
        }

        //Oprire/Pornire muzica
        private void ButonMuzica_Click(object sender, RoutedEventArgs e)
        {
            if (myMediaPlayer.IsLooping)
            {
                myMediaPlayer.Stop();
                myMediaPlayer.IsLooping = false;
                ButonMuzica.Content = "Porneste muzica";
            }
            else
            {
                myMediaPlayer.Play();
                myMediaPlayer.IsLooping = true;
                ButonMuzica.Content = "Opreste muzica";
            }
        }

        //Navigare
        private void MyFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if(Item1.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S1_P1))
                {

                    ButonNavigareInainte.IsEnabled = false;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    ButonNavigareInapoi.IsEnabled = false;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina2.Foreground = Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S1_P2))
                {
                    ButonNavigareInapoi.IsEnabled = true;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                    Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S1_P3))
                {
                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S1_P4))
                {
                    ButonNavigareInainte.IsEnabled = true;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S1_P5))
                {
                    ButonNavigareInainte.IsEnabled = false;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }
            }

            if(Item2.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S2_P1))
                {
                    ButonNavigareInainte.IsEnabled = true;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    ButonNavigareInapoi.IsEnabled = false;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina2.Foreground = Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S2_P2))
                {
                    ButonNavigareInapoi.IsEnabled = true;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                    Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S2_P3))
                {
                    ButonNavigareInainte.IsEnabled = true;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S2_P4))
                {
                    ButonNavigareInainte.IsEnabled = false;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }
            }

            if(Item3.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S3_P1))
                {
                    ButonNavigareInainte.IsEnabled = true;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    ButonNavigareInapoi.IsEnabled = false;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina1.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina2.Foreground = Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S3_P2))
                {
                    ButonNavigareInapoi.IsEnabled = true;
                    ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                    Bulina2.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S3_P3))
                {
                    Bulina3.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S3_P4))
                {
                    ButonNavigareInainte.IsEnabled = true;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));

                    Bulina4.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                    Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 179, 179, 179));
                }

                if (MyFrame.CurrentSourcePageType == typeof(S3_P5))
                {
                    ButonNavigareInainte.IsEnabled = false;
                    ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                    Bulina5.Foreground = new SolidColorBrush(Color.FromArgb(255, 117, 36, 94));
                }
            }
            
            if(Item4.IsSelected)
            {
                ButonNavigareInainte.IsEnabled = false;
                ButonNavigareInainte.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));

                ButonNavigareInapoi.IsEnabled = false;
                ButonNavigareInapoi.Foreground = new SolidColorBrush(Color.FromArgb(255, 234, 234, 234));
            }

        }

        private void ButonNavigareInainte_Click(object sender, RoutedEventArgs e)
        {
            if(Item1.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S1_P1))
                    MyFrame.Navigate(typeof(S1_P2), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S1_P2))
                    MyFrame.Navigate(typeof(S1_P3), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S1_P3))
                    MyFrame.Navigate(typeof(S1_P4), null);

                else
                    MyFrame.Navigate(typeof(S1_P5), null);
            }

            if(Item2.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S2_P1))
                    MyFrame.Navigate(typeof(S2_P2), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S2_P2))
                    MyFrame.Navigate(typeof(S2_P3), null);

                else 
                    MyFrame.Navigate(typeof(S2_P4), null);
            }

            if(Item3.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S3_P1))
                    MyFrame.Navigate(typeof(S3_P2), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S3_P2))
                    MyFrame.Navigate(typeof(S3_P3), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S3_P3))
                    MyFrame.Navigate(typeof(S3_P4), null);

                else
                    MyFrame.Navigate(typeof(S3_P5), null);
            }
        }

        private void ButonNavigareInapoi_Click(object sender, RoutedEventArgs e)
        {
            if(Item1.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S1_P2))
                    MyFrame.Navigate(typeof(S1_P1), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S1_P3))
                    MyFrame.Navigate(typeof(S1_P2), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S1_P4))
                    MyFrame.Navigate(typeof(S1_P3), null);

                else
                    MyFrame.Navigate(typeof(S1_P4), null);
            }

            if (Item2.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S2_P2))
                    MyFrame.Navigate(typeof(S2_P1), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S2_P3))
                    MyFrame.Navigate(typeof(S2_P2), null);

                else
                    MyFrame.Navigate(typeof(S2_P3), null);
            }

            if (Item3.IsSelected)
            {
                if (MyFrame.CurrentSourcePageType == typeof(S3_P2))
                    MyFrame.Navigate(typeof(S3_P1), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S3_P3))
                    MyFrame.Navigate(typeof(S3_P2), null);

                else if (MyFrame.CurrentSourcePageType == typeof(S3_P4))
                    MyFrame.Navigate(typeof(S3_P3), null);

                else
                    MyFrame.Navigate(typeof(S3_P4), null);
            }
        }
    }
}
