using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiHrizantemi = int.Parse(Console.ReadLine());
            var broiRozi = int.Parse(Console.ReadLine());
            var broiLaleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var Praznik = Console.ReadLine().ToLower();

            double hrprice = 2.00;//зададох тук цената за да не я задавам двапъти в if и в else
            double roprice = 4.10;
            double laprice = 2.50;

            if (season == "spring" || season == "summer")
            {
                hrprice *= broiHrizantemi;//трябва да умножиш броя на хризантемите по цената им.
                roprice *= broiRozi;//трябва да умножиш броя на розите по цената им.
                laprice *= broiLaleta;//трябва да умножиш броя на лалетата по цената им.
            }
            else//условието е казано че входа няма ще бъде Autum,Summer,Winter or Spring следователно този if е излишен
            {
                hrprice = 3.75;//задавам новата цена която е за winter и autum
                roprice = 4.50;
                laprice = 4.15;
                hrprice *= broiHrizantemi;
                roprice *= broiRozi;
                laprice *= broiLaleta;
            }


            double totalprice = hrprice + roprice + laprice;//тук имаше печатна грешка , вместо "+" беше написал "="

            if (Praznik == "y")//в условието е казано че намаленията се изпълняват в следния ред: празник ; >7 лалета ; >=10 рози ; >=20 цветя
            {
                totalprice += totalprice * 0.15;//15 процена от нещо са то умножено по 0,15
                //тук ползвам += за да добавя към сегашната цена 15% от нея
            }
            if (broiLaleta > 7 && season == "spring")
            {
                totalprice -= totalprice * 0.05;//5 процена от нещо са то умножено по 0,05
                //тук ползвам -= за да извадя от сегашната цена 5% от нея
            }
            if (broiRozi >= 10 && season == "winter")
            {
                totalprice -= totalprice * 0.1;//10 процента от нещо са то умножено по 0,1
                // за да сметнеш отсъпка трябва да сметнеш x процента от цената която имаш и да извадиш полученото от цената
            }

            if (broiRozi + broiLaleta + broiHrizantemi >= 20)
            {
                totalprice -= totalprice * 0.2;//20 процента от нещо са то умножено по 0,2
            }
            //Console.WriteLine(Math.Round(totalprice, 2)); не използваме Math.Round , защото от нас се иска да изведем числото форматирано до втория знак след запетаята , а не закръглено.
            Console.WriteLine("{0:f2}", totalprice + 2);// цената +2 , защото е казано че аранжирането на кой да е букет струва 2 лева
        }
    }
}