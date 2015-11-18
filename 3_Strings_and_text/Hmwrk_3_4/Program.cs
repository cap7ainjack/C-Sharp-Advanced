using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            TextFilter(bannedWords, input);

        }

        private static void TextFilter(string[] hiddenWords, string text)
        {
            for (int i = 0; i < hiddenWords.Length; i++)
            {
                text = text.Replace(hiddenWords[i], new string('*', hiddenWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
