using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba6
{
    class ProbaSolution6
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if( num == 2)
            {
                Console.WriteLine("two");
            }
            else if( num == 10)
            {
                Console.WriteLine("ten");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
