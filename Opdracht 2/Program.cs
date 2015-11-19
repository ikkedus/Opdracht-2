using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        private const double BTW = 0.21;
        static void Main(string[] args)
        {
            Console.WriteLine("voer prijs zonder btw in");
            string input = Console.ReadLine();

            double inputPrijs=0;

            bool parseSucces = double.TryParse(input, out inputPrijs);
            while (!parseSucces)
            {
                Console.WriteLine("verkeerde input");
                Console.WriteLine("voer prijs zonder btw in");
                input = Console.ReadLine();
                parseSucces = double.TryParse(input, out inputPrijs);
            }
            double btw = inputPrijs*BTW;
            double priceIncBtw = inputPrijs + btw;
            Console.WriteLine("Prijs zonder btw :"+ inputPrijs.ToString("0.00"));
            Console.WriteLine("btw:" + btw.ToString("0.00"));
            Console.WriteLine("Prijs inclusief btw :" + priceIncBtw.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
