using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputToChar = input.ToCharArray();

            if (inputToChar.Length <= 19)
            {
                Console.Write("{0}{1}",new string (inputToChar), new string('*', 20-inputToChar.Length));
                Console.WriteLine();
            }

            else
            {
                string reducedInput = input.Remove(20, input.Length - 20);
                Console.WriteLine(reducedInput);
            }

        }
    }
}
