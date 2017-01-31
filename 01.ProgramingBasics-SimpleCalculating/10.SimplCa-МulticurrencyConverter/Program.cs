using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimplCa_МulticurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string FirstCurency = Console.ReadLine().ToUpper();
            string SecondCurency = Console.ReadLine().ToUpper();
            double FirstValue = 0.0;
            double SecondeValue = 0.0;
            if (FirstCurency=="BGN")
            {
                FirstValue += 1;
            }
            else if (FirstCurency=="USD")
            {
                FirstValue += 1.79549;
            }
            else if (FirstCurency=="GBP")
            {
                FirstValue += 2.53405;
            }
            else if (FirstCurency=="EUR")
            {
                FirstValue += 1.95583;
            }
            if (SecondCurency == "BGN")
            {
                SecondeValue += 1;
            }
            else if (SecondCurency == "USD")
            {
                SecondeValue += 1.79549;
            }
            else if (SecondCurency == "GBP")
            {
                SecondeValue += 2.53405;
            }
            else if (SecondCurency == "EUR")
            {
                SecondeValue += 1.95583;
            }
            double result = num * (FirstValue / SecondeValue);
            Console.WriteLine(Math.Round(result,2));
        }
    }
}
