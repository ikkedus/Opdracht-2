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

namespace Opdracht_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int HOURINSECONDS = 3600;
        private const int MINUTEINSECONDS = 60;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string input = textBox.Text;

            int inputNumber = 0;
            bool parseSucces = int.TryParse(input, out inputNumber);
            if (parseSucces)
            {
                int rest = inputNumber % HOURINSECONDS;
                int hours = (inputNumber - rest) / HOURINSECONDS;
                int seconds = rest % MINUTEINSECONDS;
                int minutes = ((rest - seconds) / MINUTEINSECONDS);

                output.Content = string.Format("{0}uur,{1}minuten,{2}seconden", hours, minutes, seconds);
            }
          
        }
    }
}
