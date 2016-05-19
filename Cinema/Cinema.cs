using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {


            string movieKind = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            decimal price = 0;

            switch (movieKind)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5m ;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }

            decimal result = rows * columns * price;
            Console.WriteLine("{0:F2} leva", result);

        }
    }
}
