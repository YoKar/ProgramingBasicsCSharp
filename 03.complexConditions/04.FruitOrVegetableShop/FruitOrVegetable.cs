using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitOrVegetableShop
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string FruitOrVegetable = Console.ReadLine();
            if (FruitOrVegetable=="banana"||FruitOrVegetable=="apple"||FruitOrVegetable=="kiwi"||FruitOrVegetable=="cherry"||FruitOrVegetable=="lemon"||FruitOrVegetable=="grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (FruitOrVegetable=="tomato"||FruitOrVegetable=="cucumber"||FruitOrVegetable=="pepper"||FruitOrVegetable=="carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
