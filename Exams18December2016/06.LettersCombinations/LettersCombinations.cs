using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = first; i <= second; i++)
            {
                for (int j =first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if (k!=third&&i!=third&&j!=third)
                        {
                            Console.Write("{0}{1}{2} ",(char)i,(char)j,(char)k);
                            counter++;
                        }
                    }
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}
