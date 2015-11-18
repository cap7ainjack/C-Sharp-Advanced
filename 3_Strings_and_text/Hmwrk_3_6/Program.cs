using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            PalindromChecker(input);

        }

        private static void PalindromChecker(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            List<string> palindromes = new List<string>();

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
               string reversed = StringReverser(array[i]);

                if (array[i] == reversed)
                {
                    //builder.Append(reversed).Append(" ");
                    palindromes.Add(reversed);
                }
            }
           // string[] stringedBuilder = builder.ToString().Split(new char[] { ' ' },
           //  StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(", ", palindromes));

        }

        private static string StringReverser(string strInput)
        {
            char[] charArray = strInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
