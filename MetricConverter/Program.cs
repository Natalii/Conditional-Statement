using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meter = decimal.Parse(Console.ReadLine());

            string first = Console.ReadLine();
            string second = Console.ReadLine();

            var m = new Dictionary<string, decimal >()
         {
                {"m", 1m},
                { "mm", 1000m},
                { "cm", 100m},
                { "mi", 0.000621371192m},
                { "in", 39.3700787m},
                { "km", 0.001m},
                { "ft", 3.2808399m},
                { "yd", 1.0936133m}
                };
            decimal result = meter * (m[first] * m[second]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), second);
        }
    }
}
