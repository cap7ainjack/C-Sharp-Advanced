using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_2_3_M_shuffling
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[,] matrix =
            {
                {1, 2, 3},
                {4, 5, 6}
            };
          

            string[] input = new string[4];
            int temp = 0;

            input = Console.ReadLine().Split(' ').ToArray();

            while (!(input[0] == "end" ))
            {

                int x1 = int.Parse(input[1]);
                int y1 = int.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);

                
              //  if (input[0] == "swap")
              //  {
                    try
                    {
                        temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;

                        //print
                       
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                
                }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid input");
                        ;
                    }

                input = Console.ReadLine().Split(' ').ToArray();

                //   }



            }
        }
    }
}
