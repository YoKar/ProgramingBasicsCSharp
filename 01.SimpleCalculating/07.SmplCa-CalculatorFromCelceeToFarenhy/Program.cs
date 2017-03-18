using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SmplCa_CalculatorFromCelceeToFarenhy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formulata ot C kum F: C * 1.8 +32
            //Formula ot F kum C : (F - 32) / 1.8
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;
            Console.WriteLine("{0}",Math.Round(F,2));
        }
    }
}
