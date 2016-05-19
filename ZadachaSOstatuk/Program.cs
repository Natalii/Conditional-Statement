using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaSOstatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 10);// vrushta poslednata cifra ot vuvedenoto chislo ako e nechetno

            var num = 5;
            Console.WriteLine(num / 2);
            Console.WriteLine(num%2);// procentno delenie, vrushta (0 ili 1)


        }

    }
}
