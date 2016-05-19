using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 3;
            // var b = 7;
            // Console.WriteLine(a>b);
            // Console.WriteLine(a<b);
            //  Console.WriteLine(a==b);

            //  var mark = double.Parse(Console.ReadLine());
            // if (mark >= 5.50)
            // {
            //     Console.WriteLine("Excellent!");
            //  }
            // else
            //{
            //    Console.WriteLine("Slabak!");



            var name = Console.ReadLine();
            if (name == "Pesho")
            {
                Console.WriteLine("Excellent");
            }
            else if (name == "Maria")
            {
                Console.WriteLine("Buenos dias, Maria!");
            }
            else
            {
                Console.WriteLine("not for here!");


                    var grade = double.Parse(Console.ReadLine());
                    if (grade >= 5.50)
                    {
                        Console.WriteLine("Excellent!");
                    }
                }
            }
        }
    }

