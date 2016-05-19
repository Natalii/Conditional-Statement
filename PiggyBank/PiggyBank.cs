using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int priceOfTheTank = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());

            if (partyDays > 8)
            {
                Console.WriteLine("never");
            }
            else
            {
                int normalDays = 30 - partyDays;

                int savingsPerMonth = normalDays * 2;
                int expensesPerMOnth = partyDays * 5;
                int totalBalance = savingsPerMonth - expensesPerMOnth;

                double totalMonthRequired = (double)priceOfTheTank / totalBalance;
                int result = (int)Math.Ceiling(totalMonthRequired);
                int years = result / 12;
                int months = result % 12;
                Console.WriteLine("{0} years, {1} months",years, months);
            }
        }
    }
}
