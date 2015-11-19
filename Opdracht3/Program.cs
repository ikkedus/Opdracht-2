using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {
        private const int HOURINSECONDS = 3600;
        private const int MINUTEINSECONDS = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("voer aantal seconden in");
            string input = Console.ReadLine();

            int inputNumber = 0;
            bool parseSucces = int.TryParse(input, out inputNumber);
            while (!parseSucces)
            {
                Console.WriteLine("verkeerde input");
                Console.WriteLine("voer aantal seconden in");
                input = Console.ReadLine();
                parseSucces = int.TryParse(input, out inputNumber);
            }
          
            int rest = inputNumber%HOURINSECONDS;
            int hours = (inputNumber - rest)/HOURINSECONDS;
            int seconds = rest%MINUTEINSECONDS;
            int minutes = ((rest - seconds) / MINUTEINSECONDS);

            Console.WriteLine("{0}:{1}:{2}",hours,minutes,seconds);
           Console.ReadKey();
        }
    }
}
