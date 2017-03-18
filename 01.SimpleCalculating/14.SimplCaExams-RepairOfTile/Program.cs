using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SimplCaExams_RepairOfTile
{
    class Program
    {
        static void Main(string[] args)
        {
            int TileSize = int.Parse(Console.ReadLine());
            double WeidgthOfPLate = double.Parse(Console.ReadLine());
            double LenghtOfPLate = double.Parse(Console.ReadLine());
            int BenchsWiegth = int.Parse(Console.ReadLine());
            int BenchLenght = int.Parse(Console.ReadLine());
            int areaOfTile = TileSize * TileSize;
            double areaOfPLate = WeidgthOfPLate * LenghtOfPLate;
            int areaOfBench = BenchsWiegth * BenchLenght;
            double numberOfPLates = (areaOfTile - areaOfBench) / areaOfPLate;
            double timeForPlaced = (numberOfPLates * 0.2);
            Console.WriteLine(numberOfPLates);
            Console.WriteLine(timeForPlaced);
        }
    }
}
