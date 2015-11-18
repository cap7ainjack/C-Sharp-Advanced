using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_1_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] seq = input.Distinct().ToArray();

            List<int> currentCombine = new List<int>();

            double combinations = Math.Pow(2, seq.Length);
            bool matchfound = false;

            for (int mask = 0; mask < combinations; mask++)
            {
                for (int i = 0; i < seq.Length; i++)            
                {
                    if ((mask & (1 << i)) != 0 )                //placed like this the two loops and this IF excluding
                    {                                           // zeros, go thrue the whole array, go thrue all possible
                        currentCombine.Add(seq[i]);             //combinations :)
                    }

                }


                if (currentCombine.Sum() == sum)
                {
                    Console.WriteLine("{0} = {1}", string.Join("+",currentCombine),sum);
                    matchfound = true;
                }

                currentCombine.Clear();

            }

            if (matchfound)
            {
                Console.WriteLine("No matching subsets.");
            }




        }
        }
    }

