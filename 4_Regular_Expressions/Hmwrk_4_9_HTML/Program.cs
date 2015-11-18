using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_9_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://pastebin.com/AMi4X4mk

            string input = Console.ReadLine();

            string patternFirstPatt = @"<div(\s*.+)?\s+\w+\s?=\s?""(\w +)""\s*(\s.+)?>";

            Regex divReplace = new Regex(patternFirstPatt); 
            MatchCollection matches = divReplace.Matches(input);

            StringBuilder result = new StringBuilder();

            foreach (Match item in matches)
            {
                string newText = "<" + item.Groups[2].Value  + item.Groups[1].Value + item.Groups[3].Value + ">";
                

               // fullText.Append(currentMatch);

                result.Append(newText);
            }

            Console.WriteLine(result);
            
        }
    }
}
