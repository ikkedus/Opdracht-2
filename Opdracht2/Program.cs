using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("voer in hoeveel getalen er ingevoerd moeten worden");
            string input = Console.ReadLine();

            int iteration = 0;
            List<int> listOfNumbers = new List<int>();

            bool parseSucces = int.TryParse(input, out iteration);
            while (!parseSucces)
            {
                Console.WriteLine("verkeerde input");
                Console.WriteLine("voer een getal in");
                input = Console.ReadLine();
                parseSucces = int.TryParse(input, out iteration);
            }
            for (int i = 0; i < iteration;)
            {
                Console.WriteLine("voer getal"+(i + 1) +" in");
                input = Console.ReadLine();
                int number = 0;
                parseSucces = int.TryParse(input, out number);
                while (!parseSucces)
                {
                    Console.WriteLine("verkeerde input");
                    Console.WriteLine("voer een getal in");
                    input = Console.ReadLine();
                    parseSucces = int.TryParse(input, out number);
                }
                listOfNumbers.Add(number);
                i++;
            }
            float total = (float)(listOfNumbers.Sum(x => x)) / iteration;
            Console.WriteLine("het gemiddelde van deze getalen is: "+total);
            Console.ReadKey();
        }
    }
}
