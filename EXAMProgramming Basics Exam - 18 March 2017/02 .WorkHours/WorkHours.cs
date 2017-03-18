using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int wurkersNumber = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var realHours = (wurkersNumber * 8) * days;

            if (realHours>hoursNeeded)
            {
                Console.WriteLine( "{0} hours left",realHours-hoursNeeded);
            }
            else
            {
                Console.WriteLine("{0} overtime",hoursNeeded-realHours);
                Console.WriteLine("Penalties: {0}",(hoursNeeded-realHours)*days);
            }
        }
    }
}
