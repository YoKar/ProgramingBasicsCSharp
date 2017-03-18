using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = (12 * n - 6) / 2;
            int hashtag = 1;
            int counter = 0;
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.',dots),new string('#',hashtag));
                dots -= 3;
                hashtag += 6;
                counter++;
            }
            hashtag -= 12;
            dots = 0;
            for (int i = 0; i < ((4*n-2)-counter)-n; i++)
            {
                Console.WriteLine("|..{0}{1}{0}...", new string('.',dots),new string('#',hashtag));
                hashtag -= 6;
                dots += 3;
            }
          
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("|..{0}{1}{0}...", new string('.', dots), new string('#', hashtag));
            }
            Console.WriteLine("@..{0}{1}{0}...", new string('.', dots), new string('#', hashtag));
        }
    }
}
