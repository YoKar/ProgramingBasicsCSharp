using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SimplCond_EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstWord = Console.ReadLine().ToLower();
            string SecondWord = Console.ReadLine().ToLower();
            if (FirstWord==SecondWord||SecondWord==FirstWord)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
