using System;

using System.Windows;


namespace Opdracht_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double KOSTENBROEKEN = 100;
        private const double KOSTENSHIRTS = 30;
        private const double BTW = 0.21;
        public MainWindow()
        {
            InitializeComponent();
            datum.Content = DateTime.Now;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int aantalbroek = 0;
            int aantalshirt = 0;
            bool parseSucces = int.TryParse(aantalBroeken.Text, out aantalbroek) && int.TryParse(aantalShirts.Text, out aantalshirt);
            if (parseSucces)
            {

                double totaalbroeken = KOSTENBROEKEN*aantalbroek;
                double totaalshirts = KOSTENSHIRTS * aantalshirt;
                
                double btwbedrag = (totaalbroeken + totaalshirts)*BTW;

                double totaalbedrag = (totaalbroeken + totaalshirts) + btwbedrag;
                
                btw.Content = btwbedrag.ToString("€0.00");
                totaal.Content = totaalbedrag.ToString("€0.00");
                datum.Content = DateTime.Now;
                prijs.Content = (totaalbroeken + totaalshirts).ToString("€0.00");
            }
        }
    }
}
