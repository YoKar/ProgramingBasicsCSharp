using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SimplCaExams_DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int DaysInMonth = int.Parse(Console.ReadLine());
            double MoneyPerDay = double.Parse(Console.ReadLine());
            double USDtoBGN = double.Parse(Console.ReadLine());
            double bonus = (DaysInMonth * 2.5) * MoneyPerDay;
            double MoneyPerYear = ((DaysInMonth * 12) * MoneyPerDay)+bonus;
            double AfterTaxes = MoneyPerYear - (MoneyPerYear * 0.25);
            double allMoneyInBGN = AfterTaxes * USDtoBGN;
            Console.WriteLine("{0:f2}",(allMoneyInBGN/365));
        }
    }
}
