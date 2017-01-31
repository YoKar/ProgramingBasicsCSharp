using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SimplCalExams_VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceForVegetableInKG = double.Parse(Console.ReadLine());
            double PriceForFruetInKG = double.Parse(Console.ReadLine());
            int AllVegetablesKG = int.Parse(Console.ReadLine());
            int AllFruetesKG = int.Parse(Console.ReadLine());
            double VegetablePrice = PriceForVegetableInKG * AllVegetablesKG;
            double FruetesPrice = PriceForFruetInKG * AllFruetesKG;
            double PriceInEUR = (VegetablePrice + FruetesPrice) / 1.94;
            Console.WriteLine(PriceInEUR);
        }
    }
}
