using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_8_use_chains
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string patternText = @"(<p>)(?<text>[^>]+)(<\/p>)";
            string patternNotValids = @"[^a-z\d\s]";
            string patternSpaces = @"[\s+]+";

            Regex regexInput = new Regex(patternText);
            Regex notValids = new Regex(patternNotValids);
            Regex whiteSpaces = new Regex(patternSpaces);

            StringBuilder fullText = new StringBuilder();
            MatchCollection matched = regexInput.Matches(input);

            foreach (Match item in matched)
            {
                string currentMatch = notValids.Replace(item.Groups["text"].Value, " ");
                currentMatch = whiteSpaces.Replace(currentMatch, " ");
             
                fullText.Append(currentMatch);
            }


            // convert the letters

            for (int i = 0; i < fullText.Length; i++)
            {
                char letter = fullText[i];

                if (letter < 'n' && letter >= 'a')
                {
                    letter = (char)(letter + 13);
                }

                else if (letter <= 'z' && letter >= 'n')
                {
                    letter = (char)(letter - 13);
                }

                fullText[i] = letter;
            }

            Console.WriteLine(fullText);
        }
    }
}
