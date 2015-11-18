using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmrk_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string keyWord = Console.ReadLine();

            NumberOfOccurences(input, keyWord);
        }



        private static void NumberOfOccurences(string textInput, string wantedWord)
        {
            int count = 0;
            int startIndex = 0;

            textInput = textInput.ToLower();
            wantedWord = wantedWord.ToLower();

            for (int i = 0; i < textInput.Length; i++)
            {
                int index = textInput.IndexOf(wantedWord, startIndex);

                if (index != -1)
                {
                    startIndex = index + 1;
                    count++;
                }

            }

            Console.WriteLine(count);
        }
    }
    
}
