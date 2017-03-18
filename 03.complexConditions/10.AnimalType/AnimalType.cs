using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();
            string type = "";
            if (animal == "dog" || animal == "crocodile" || animal == "tortoise" || animal == "snake")
            {
                switch (animal)
                {

                    case "dog":
                        type = "mammal";
                        break;
                    case "crocodile":
                        type = "reptile";
                        break;
                    case "tortoise":
                        type = "reptile";
                        break;
                    case "snake":
                        type = "reptile";
                        break;
                    case "":
                        type = "unknown";
                        break;
                }
                Console.WriteLine(type);
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
