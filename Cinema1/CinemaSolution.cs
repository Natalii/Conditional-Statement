using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema1
{
    class CinemaSolution
    {
        static void Main(string[] args)
        {
            string movieKiind = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double priceTicket = 0.0;
            int totalPlace = rows * columns;
            double totalIncome = 0.0;

            if (movieKiind == "Premiere")
            {
                priceTicket = 12.0;
            }
            else if (movieKiind == "Normal")
            {
                priceTicket = 7.5;
            }
            else if (movieKiind == "Discount")
            {
                priceTicket = 5.00;
            }
            totalIncome = totalPlace * priceTicket;
            Console.WriteLine("{0:F2} leva", totalIncome);
        }
    }
}
