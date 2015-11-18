using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder alphabet = new StringBuilder();

            for (int i = 'a'; i <= 'z'; i++)
            {
                alphabet.Append((char)i);
            }

            string first10LettersFromAlphabet = alphabet.substring(0, 10);
            Console.WriteLine(first10LettersFromAlphabet);
        }
    }
}
