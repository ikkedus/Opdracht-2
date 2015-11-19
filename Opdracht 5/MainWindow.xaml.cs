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

namespace Opdracht_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("voer een getal in");
            string input1 = inputBox1.Text;
            string input2 = inputBox2.Text;
            string input3 = inputBox3.Text;
            int inputValue1 = 0;
            int inputValue2 = 0;
            int inputValue3 = 0;
            float total = 0;
            bool parseSucces = int.TryParse(input1, out inputValue1) && int.TryParse(input2, out inputValue2) && int.TryParse(input3, out inputValue3);
            if (parseSucces)
            {
                total = inputValue1 + inputValue2 + inputValue3;
                total = total/3;
                uitkomst.Content = total;
            }
            else
            {
                uitkomst.Content = "error controlleer getalen";
            }
            

        }
    }
}
