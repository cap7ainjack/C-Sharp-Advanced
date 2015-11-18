using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringReverser(input));
        }

        private static string StringReverser(string strInput)
        {
            char[] charArray = strInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
