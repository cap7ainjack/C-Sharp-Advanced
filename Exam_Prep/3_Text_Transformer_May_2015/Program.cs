using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Text_Transformer_May_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            while (input != "burp")
            {
                builder.Append(input);

                input = Console.ReadLine();
            }

            //remove whitespaces
            string text = Regex.Replace(builder.ToString(), @"\s+", " ");
         //  Console.Clear();
            FindWords(text);

        }

        private static void FindWords(string text)
        {
            string pattern = @"([$%&'])([^$%&']+)\1";
            Regex wordFinder = new Regex(pattern);

            MatchCollection matches = wordFinder.Matches(text);
            StringBuilder results = new StringBuilder();
            int weight=0;
            foreach (Match word in matches)
            {
                switch (word.Groups[1].Value)
                {
                    case "$":
                         weight = 1;
                        break;
                    case "%":
                        weight = 2;
                        break;
                    case "&":
                        weight = 3;
                        break;
                    case "'":
                        weight = 4;
                        break;
                }

                char[] letter = word.Groups[2].Value.ToCharArray();
                char currentLetter;
                for (int i = 0; i < letter.Length; i++)
                {
                    if (i % 2 ==0)
                    {
                        currentLetter =(char)(letter[i] + weight);
                    }

                    else
                    {
                        currentLetter = (char)(letter[i] - weight);
                    }
                    results.Append(currentLetter);
                }
               
                Console.Write(results + " ");
                results.Clear();
            }

           Console.WriteLine();
        }
    }
}
