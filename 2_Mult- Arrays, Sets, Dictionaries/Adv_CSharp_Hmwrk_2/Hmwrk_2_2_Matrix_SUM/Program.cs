using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_2_2_Matrix_SUM
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

           // int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int [,] matrix = new int[n,m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (input.Length != matrix.GetLength(1))
                {
                    throw new ArgumentException("Invalid column input");
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int num = input[col];
                    matrix[row, col] = num;
                }
                
            }
            

            // Matrix platform 3x3

            int bestsum = int.MinValue;
            int bestrow = 0;
            int bestCol = 0;

            int platformRows = 3;
            int platformCols = 3;

            for (int row = 0; row <= matrix.GetLength(0) - platformRows; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - platformCols; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                              matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                              matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                    if (sum > bestsum)
                    {
                        bestsum = sum;
                        bestrow = row;
                        bestCol = col;
                    }
                }

                
            }


            //print best sum plus best platform

            Console.WriteLine("Best platform: ");

            int[,] bestPlatform = new int[platformRows,platformCols];

            for (int row = bestrow; row <= bestPlatform.GetLength(0); row++)
            {
                for (int col = bestCol; col <= bestPlatform.GetLength(1); col++)
                {
                    Console.Write("{0} ",matrix[row,col]);

                }

                Console.WriteLine();
            }

            Console.WriteLine("Best sum: {0}", bestsum);



            //print the matrix
            //Console.WriteLine("The matrix itself: ");
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("{0} ",matrix[row,col] );
            //    }

            //    Console.WriteLine();
            //}

        }
    }
}
