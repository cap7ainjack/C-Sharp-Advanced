using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            GetUnicodeCharacters(inputString);
        }

        private static void GetUnicodeCharacters(string input)
        {
            byte[] inputBytes = Encoding.Unicode.GetBytes(input);
            char[] inputChars = Encoding.Unicode.GetChars(inputBytes);

            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(inputChars, c=> builder.AppendFormat("\\u00{0:x}", (int)c));
            Console.WriteLine(builder);
            
        }
    }
}
