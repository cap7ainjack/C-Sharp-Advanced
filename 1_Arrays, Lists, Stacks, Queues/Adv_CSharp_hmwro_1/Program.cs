using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_CSharp_hmwro_1
{
    class Homework_1_1
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] items = array.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[items.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            Array.Sort(numbers);
            Console.WriteLine(string.Join(",", numbers));

        }
    }
}
