using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var num = int.Parse(Console.ReadLine());
            var num1 = int.Parse(Console.ReadLine());
            if (num > num1)
            {
                Console.WriteLine("Greater number: {0}", num);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", num1);
            }
        }
    }
}
