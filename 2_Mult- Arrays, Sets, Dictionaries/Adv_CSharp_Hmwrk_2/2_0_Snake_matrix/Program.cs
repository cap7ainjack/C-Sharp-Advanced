﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_0_Snake_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,m];
            int counter = 1;
            int rowCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (rowCount == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                        rowCount++;
                    }
                }
                row++;
                if (rowCount != 0 && row < matrix.GetLength(0))
                {
                    
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                     
                    rowCount = 0;
                }
            }
            // print the result

            // Print the result matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();


        }
    }
}
