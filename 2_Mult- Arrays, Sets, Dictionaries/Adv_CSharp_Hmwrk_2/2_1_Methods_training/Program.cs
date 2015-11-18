using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Methods_training
{
    internal class Program
    {
        private static void Main()
        {

            Console.WriteLine("Enter first month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second month (1-12: ");
            int secondMonth = int.Parse(Console.ReadLine());

            SayPeriod(firstMonth, secondMonth);
        }

        private static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period <0)
            {
                period += 12;
            }

            Console.WriteLine("There are {0} months from: ",period);
            SayMonth(startMonth);
            Console.WriteLine("to");
            SayMonth(endMonth);
            Console.WriteLine(".");
        }

        private static void SayMonth(int month)
        {
            string[] monthNames = new string[]
            {
                "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
            };

            string monthName = monthNames[month - 1];
            Console.WriteLine(monthName);
        }
    }
}
