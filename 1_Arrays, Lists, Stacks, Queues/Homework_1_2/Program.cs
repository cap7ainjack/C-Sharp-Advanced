using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_2
{
    class Homework_1_2
    {
        static void Main(string[] args)
        {
            // ====================Bubble method ===============

            string array = Console.ReadLine();
            string[] items = array.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[items.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        swapped = true;
                    }
                }

            } while (swapped == true);


            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
