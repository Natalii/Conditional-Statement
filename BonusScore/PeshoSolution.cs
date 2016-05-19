using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class PeshoSolution
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            if (name == "Pesho")// или се изписва така: (name == "Pesho" && age == 16)
            {
                if (age == 16)
                {
                    Console.WriteLine("sorry pesho, no si na 16 i nqma bira");
                }
                else
                {
                    Console.WriteLine(" sori pesho");
                }
            }
        }
    }
}
