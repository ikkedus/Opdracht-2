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

namespace Opdracht_7
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

        private void wissen_Click(object sender, RoutedEventArgs e)
        {
            beginKM.Text = "";
            eindKM.Text = "";
            prijsPerKM.Text = "";
            prijsEx.Content = "";
            prijsInc.Content = "";
            btw.Content = "";
        }

        private void bereken_Click(object sender, RoutedEventArgs e)
        {
            int _beginKm = 0;
            int _eindKm = 0;
            double tarief = 0;
            bool parseSucces = int.TryParse(beginKM.Text, out _beginKm) && int.TryParse(eindKM.Text, out _eindKm) && double.TryParse(prijsPerKM.Text, out tarief);
            if (parseSucces && _beginKm <= _eindKm)
            {
                double bedrag = (double)(_eindKm - _beginKm)*tarief;
                double btwbedrag = bedrag*BTW;
                double totaal = bedrag + btwbedrag;
                prijsEx.Content = bedrag.ToString("0.00");
                btw.Content = btwbedrag.ToString("0.00");
                prijsInc.Content = totaal.ToString("0.00");
            }
            else
            {
                error.Content = "error incorrecte invoer";
            }
        }
    }
}
