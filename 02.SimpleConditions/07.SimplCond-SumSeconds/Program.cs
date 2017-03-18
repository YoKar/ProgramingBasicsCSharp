using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SimplCond_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstAthlete = int.Parse(Console.ReadLine());
            int SecindAthlete = int.Parse(Console.ReadLine());
            int ThirdAthlete = int.Parse(Console.ReadLine());
            int allSeconds = FirstAthlete + SecindAthlete + ThirdAthlete;
            int minutes = (allSeconds / 60);
            int seconds = allSeconds % 60;
            Console.WriteLine("{0}:{1:d2}",minutes,seconds);
        }
    }
}
