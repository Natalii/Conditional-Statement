using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBank
{
    class PBank
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int partydays = int.Parse(Console.ReadLine());

            int monthdays = 30 - partydays;
            int profit = monthdays * 2;
            int expenses = monthdays - partydays;
        }
    }
}
