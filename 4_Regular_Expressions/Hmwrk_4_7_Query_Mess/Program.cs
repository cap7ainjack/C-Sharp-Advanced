using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hmwrk_4_7_Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<key>[^&?]+)=(?<value>[^&?]+)";
            string patternSpaces = @"(\+|\%20)";

            Regex regex = new Regex(pattern);
            Regex spaceRegex = new Regex(patternSpaces);

            while (input!="END")
            {

                    //spaceRegex.Replace(input, " ");
                string replacedInput = spaceRegex.Replace(input, " ");
                

                MatchCollection matches = regex.Matches(replacedInput);
         ;
                Dictionary<string, List<string>>  results = new Dictionary<string, List<string>>();

            
                
                foreach (Match match in matches)
                {
                    if (!results.ContainsKey(match.Groups["key"].Value))
                    {
                        results.Add(match.Groups["key"].Value, new List<string>());
                    }

                    results[match.Groups["key"].Value].Add(match.Groups["value"].Value); 
                 }

                foreach (var r in results)
                {
                    Console.WriteLine("{0}=[{1}]", r.Key, string.Join(",",r.Value));
                }

                Console.WriteLine();
                input = Console.ReadLine();

            }

        }
    }
}
