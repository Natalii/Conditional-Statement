using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPointsProba
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonusTochki = 0.0;

            if (number<=100)
            {
                bonusTochki = 5;
            }
            else if (number>100 && number <=1000)
            {
                bonusTochki += number * 0.2;
            }
            else if (number > 1000)
            {
                bonusTochki = number * 0.1;
            }
            if (number %2 == 0)
            {
                bonusTochki += 1;
            }
            else if (number %10 == 5)
            {
                bonusTochki += 2;
            }

            var totalPoints = bonusTochki + number;
            Console.WriteLine(bonusTochki);
            Console.WriteLine(totalPoints);
        }
    }
}
