using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_3_7_stpBystp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            double[] allResults = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                string currentSeq = input[i];
                string digits = "";

                int firstLetterUpper = currentSeq[0] - 64; // get the first letter alphabet number (from ASCII) upper lett
                int firstLetterLower = currentSeq[0] - 96; // get the first letter alphabet number (from ASCII) lower lett
                int lastLetterUpper = currentSeq[currentSeq.Length - 1] - 64;
                int lastLetterLower = currentSeq[currentSeq.Length - 1] - 96;
                //get the number
                for (int j = 0; j < currentSeq.Length; j++)
                {
                    if (char.IsDigit(currentSeq[j]))
                    {
                        digits = digits + currentSeq[j];
                    }
                }

                double result = double.Parse(digits);


                // if first letter is upper letter
                if (char.IsUpper(currentSeq[0]))
                {
                    result = result / firstLetterUpper;
                }
                else
                {
                    result = result * firstLetterLower;
                }

                // add the last letter
                if (char.IsUpper(currentSeq[currentSeq.Length - 1]))
                {
                    result = result - lastLetterUpper;
                }
                else
                {
                    result = result + lastLetterLower;
                }

                allResults[i] = result;
                // Console.WriteLine(result);
            }

            // Console.WriteLine(string.Join(" ",allResults));
            Console.WriteLine("{0:F2}", allResults.Sum());

        }
    }
}
