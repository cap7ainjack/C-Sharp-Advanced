using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_3
{
    class HomeWork3
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] items = array.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            double[] numbers = new Double[items.Length];

            List<double> floating_list = new List<double>();
            List<double> non_floating_list = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(items[i]);

                if (Math.Round(numbers[i]) != numbers[i])
                {
                    floating_list.Add(numbers[i]);
                }

                else
                {
                    non_floating_list.Add(numbers[i]);
                }
            }


            // floating_list.ForEach(i => Console.Write(i + ", "));
            //Console.WriteLine();
            // non_floating_list.ForEach(i => Console.Write(i+ ", "));
            //Console.WriteLine();

            Console.Write(string.Join(", ", floating_list));
            Console.WriteLine(" -->  min: {0} max: {1} sum: {2} avg: {3:F2}",floating_list.Min(), floating_list.Max(),
                                                                          floating_list.Sum(),floating_list.Average());
           
            Console.Write(string.Join(", ", non_floating_list));
            Console.WriteLine(" -->  min: {0} max: {1} sum: {2} avg:{3:f2}", non_floating_list.Min(), non_floating_list.Max(), 
                                                                          non_floating_list.Sum(),non_floating_list.Average());
        }
    }
}
