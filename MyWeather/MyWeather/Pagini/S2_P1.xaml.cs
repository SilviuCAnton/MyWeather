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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWeather.Pagini
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S2_P1 : Page
    {
        public S2_P1()
        {
            this.InitializeComponent();
            TextBlockDescriere.Text = "";
            TextBlockSubtitlu.Text = ""; 
        }

        private void Bulina1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TextBlockSubtitlu.Text = "TEMPERATURA";
            TextBlockDescriere.Text = "Atunci cand afara e foarte frig sau excesiv de cald, dar si in perioadele de tranzitie, bolile latente, de care sufera unii dintre noi,\nse pot acutiza." +
                " Nu trebuie sa ne mire daca schimbarile bruste ale vremii ne dau dureri de cap, ameteli sau chiar irascibilitate.\nInhalarea aerului rece poate intretine crizele de astm. Masele" +
                " de aer reci cresc tensiunea arteriala, ingreuneaza gandirea si\nprovoaca apatie. Caldurile excesive cresc relativ brusc valorile tensiunii arteriale si precipita dureri anginoase.";
        }

        private void Bulina2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TextBlockSubtitlu.Text = "PRECIPITATIILE SI UMIDITATEA";
            TextBlockDescriere.Text = "Aerul foarte uscat este daunator aparatului respirator, iar cel umed favorizeaza nefritele si bolile infecto-contagioase. Vremea\ninchisa agraveaza depresiile," +
                " mai ales din cauza faptului ca oamenii petrec mai mult timp in casa. Durerile reumatice si de\narticulatii – din pricina aerului umed si rece. Aerul cald si umed este un adevarat" +
                " cosmar pentru persoanele sensibile care se\nplang de migrene, astm, depresii, probleme de circulatie, dereglari de somn sau infectii. Bataturile si dintii incep sa doara," +
                "\ncoagularea sangelui are de suferit si apare pericolul trombozelor.";
        }

        private void Bulina3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TextBlockSubtitlu.Text = "PRESIUNEA ATMOSFERICA";
            TextBlockDescriere.Text = "Schimbarile de presiune atmosferica produc modificari la nivelul celulelor si-al tesuturilor, creand disconfort in functionarea\norganismului." +
                " Cand valorile acesteia nu sunt in limite normale, persoanele cu hipertensiune arteriala au dureri de cap, palpitatii,\nsenzatie de greutate in piept. Cand barometrul urca," +
                " organismul produce mai multa adrenalina, colicile si crampele se\nmanifesta mai frecvent. Presiunea atmosferica scazuta duce la tahicardie si la cresterea tensiunii arteriale.";
        }
    }
}
