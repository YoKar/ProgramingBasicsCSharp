using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SimplCa_ConverterFromUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine("{0} BGN",(Math.Round(BGN,2)));
        }
    }
}
