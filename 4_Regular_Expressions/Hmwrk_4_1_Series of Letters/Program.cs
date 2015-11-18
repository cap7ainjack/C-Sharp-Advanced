using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_1_Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\w)\1+";
            string replacement = "$1";
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);

        }
    }
}
