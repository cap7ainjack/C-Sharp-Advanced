using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_1_5
{
    class Problem5LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            //longest string
            //string[] input = Console.ReadLine().Split(' ');

            // string[] input = new string[] {"2","3","4","1","50", "2", "3", "4", "5"};
           
            string array = Console.ReadLine();
            string[] input = array.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int longest_end_temp = 0;
            int longest_end = 0;
            int temp = 1;
            int longest = 0;
            List<int> list = new List<int>();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }





            for (int i = 0; i < input.Length; i++)
            {
                if ( i < input.Length - 1 && numbers[i] < numbers[i + 1])
                {
                    
                    Console.Write(input[i] + " ");
                    temp++;

                }
                else
                {
                    Console.WriteLine(input[i] + " ");

                    if (temp > longest)
                    {
                        longest = temp;
                        // list.Clear();
                        longest_end = i;
                    }
                    temp = 1;

                }
               
            }


            for (int j = longest_end; j > longest_end - longest ; j--)
            {

                list.Add(numbers[j]);
            }


            Console.Write("Longest: ");


            list.Reverse();

            foreach (int cat in list)
            {
                Console.Write(cat + " ");
            }

            Console.WriteLine();

        }
    }
}
