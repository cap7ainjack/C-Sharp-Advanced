using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_4_Sentence_extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[A-Z][^>]+?\b(is)\b[^.]*?[\.\!\?]";

            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
