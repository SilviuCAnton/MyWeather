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

namespace MyWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class S1_P4 : Page
    {
        public S1_P4()
        {
            this.InitializeComponent();
            TexblockDescriere.Text = "";
        }

        private void BulinaText1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TexblockDescriere.Text = " Vremea excitanta cuprinde complexul vremii in care unul sau mai multe din elementele meteorologice deviaza de la valorile\n optime. Aceasta vreme, desi este in fond insorita, are adeseori un cer mohorat, timpul e uscat, umiditatea ridicandu-se pana\n la 90% umiditate relativa, oscilatia temperaturii medii a zilei poate fi pana la 4 grade C, a presiunii barometrice pana la 8\n milibari, iar miscarea aerului pana la 9 m/sec.";
        }

        private void BulinaText2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TexblockDescriere.Text = " Vremea acuta reprezinta complexul vremii cu modificari accentuate ale elementelor meteorologice, cand oscilatiile termice\n depasesc 4 grade C, ale presiunii atmosferice – 8 milibari, iar viteza de miscare a aerului e mai mare de 9 m/sec.";
        }

        private void BulinaText3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TexblockDescriere.Text = " Vremea optima este considerata aceea care influenteaza favorabil, producand buna dispozitie si are o actiune menajanta asupra\n organismului. Asemenea tip de vreme se caracterizeaza prin mentinerea relativ uniforma a elementelor meteorologice:\n umiditate moderata, viteza relativ mica de miscare a aerului, zile senine, cand temperatura medie diurna nu oscileaza cu mai\n mult de 2 grade C, iar presiunea – cu mai mult de 4 milibari.";
        }
    }
}
