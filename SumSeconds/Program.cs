using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var seconds1 = int.Parse(Console.ReadLine());
            var seconds2 = int.Parse(Console.ReadLine());
            var seconds3 = int.Parse(Console.ReadLine());

            // var time = seconds1 + seconds2 + seconds3;
            int totalSeconds = seconds1 + seconds2 + seconds3;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;
            string time = minutes + ":" + String.Format("{0:00}",seconds);
            //string minSec = string.Format("{0}:{1:00}", seconds / 60,
                            //  (Math.Abs(seconds)) % 60);

            Console.WriteLine(time);
        }
    }
}
