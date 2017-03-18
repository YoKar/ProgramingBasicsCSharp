using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SimpleCaExams_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int Bitcoins = int.Parse(Console.ReadLine());
            double Yenies = double.Parse(Console.ReadLine());
            double Comision = double.Parse(Console.ReadLine());
            double BitcoinsInLV = (Bitcoins * 1168) ;
            double YeniesInLV = ((Yenies * 0.15) * 1.76);
            //Purvo se subirat i sled tova se presmqta v kolko EURO sa !!!! 
            double BitAndYeniesEUR = (BitcoinsInLV + YeniesInLV) / 1.95;
            double result = BitAndYeniesEUR;
            double comision = result * (Comision / 100);
            
            Console.WriteLine(result-comision);
        }
    }
}
