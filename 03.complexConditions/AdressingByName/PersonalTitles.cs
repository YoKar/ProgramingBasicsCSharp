using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressingByName
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double ages = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            if (sex =='f')
            {
                if (ages<16)
                {
                    Console.WriteLine("Miss");
                }
                else 
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (sex=='m')
            {
                if (ages<16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
