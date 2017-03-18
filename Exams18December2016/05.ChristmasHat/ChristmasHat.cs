using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}***{0}", new string('.', n * 2 - 1));
            var dashes = 1;
            var dosts = n*2-2;
            for (int i = 0; i < n*2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dosts), new string('-',dashes));
                dashes++;
                dosts--;
            }
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("*{0}", new string('.', 1));
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
        }
    }
}
