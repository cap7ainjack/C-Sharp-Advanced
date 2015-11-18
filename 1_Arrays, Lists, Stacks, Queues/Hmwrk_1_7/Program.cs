using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_1_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

            List<int> currentComb = new List<int>();
            List<List<int>> allcombs = new List<List<int>>();

            double combinations = Math.Pow(2, input.Length);

            for (int mask = 0; mask < combinations; mask++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        currentComb.Add(input[i]);
                    }
                }

                if (currentComb.Sum() == sum)
                {
                    allcombs.Add(currentComb);
                }

                    currentComb= new List<Int32>();
            }


            if (allcombs.Count == 0)
            {
                Console.WriteLine("No !");
            }
    
            else
            {

                allcombs.ForEach(list => list.Sort()); // sorts the elements in each list
                allcombs = allcombs.OrderBy(a => a.Count).ThenBy(b => b.First()).ToList();
                // sorts allSubsets by count and first element
                allcombs.ForEach(list => Console.WriteLine("{0} = {1}", string.Join(" + ", list), sum));
                // prints each list = sum

            }

        }
    }
}
    

