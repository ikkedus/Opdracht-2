using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opdracht_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double BTW = 0.21;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string input = prijsBox.Text;
            double inputPrijs = 0;

            bool parseSucces = double.TryParse(input, out inputPrijs);
            while (!parseSucces)
            {

                input = Console.ReadLine();
                parseSucces = double.TryParse(input, out inputPrijs);
            }
            double vat = inputPrijs * BTW;
            double priceIncBtw = inputPrijs + vat;
            prijs.Content = inputPrijs.ToString("0.00");
            btw.Content = vat.ToString("0.00");
            totaal.Content = priceIncBtw.ToString("0.00");

        }
    }
}
