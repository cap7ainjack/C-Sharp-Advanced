using System;
using System.Text.RegularExpressions;

namespace Hmwrk_4_5_Valid_user
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[a-zA-Z]\w{2,25}";
            Regex regex = new Regex(pattern);
            int longest = 0;
            int previousMatchLenght = 0;
            string firstBestMatch = null;
            string secondBestMatch = null;
            string previousMatch = null;

            foreach (Match match in regex.Matches(input))
            {

                int currentMatchLenght = match.Length;

                if (currentMatchLenght + previousMatchLenght > longest)
                {
                    longest = currentMatchLenght + previousMatchLenght;
                    firstBestMatch = previousMatch;
                    secondBestMatch = match.Value;
                }

                previousMatchLenght = match.Length;
                previousMatch = match.Value;
            }

            Console.WriteLine("Best user names are:");
            Console.WriteLine(firstBestMatch);
            Console.WriteLine(secondBestMatch);
        }
    }
}
    