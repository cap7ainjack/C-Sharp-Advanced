using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_3_Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emailPattern = @"\b([a-zA-Z0-9]+?)[\.\-]*?[a-zA-Z0-9]+?@[a-zA-Z0-9]+?([\-\.])*?\.[\w]{2,}\b";
            Regex regex = new Regex(emailPattern);

           // MatchCollection matches = regex.Matches(input);

            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
