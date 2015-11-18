using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_2_1_Fill_matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[n, m];
            int[,] matrix2 = new int[n, m];
            int counter = 1;
            int colCount = 0;
            int counter2 = 1;
            int colCount2 = 0;


            for (int col = 0; col < matrix1.GetLength(1); col++)
            {
                if (colCount == 0)
                {
                    for (int row = 0; row < matrix1.GetLength(0); row++)  // this loop is the same for the two matrixs
                    {
                        matrix1[row, col] = counter;
                        counter++;

                        // second matrix
                        matrix2[row, col] = counter2;
                        counter2++;
                    }

                    colCount = 1;
                    colCount2 = 1;
                }

                col++;  // go to the second column manualy

                // first matrix
                if (colCount != 0 && col < matrix1.GetLength(1))
                {

                    for (int row = 0; row < matrix1.GetLength(0); row++)
                    {
                        matrix1[row, col] = counter;
                        counter++;
                    }
                    colCount = 0;
                }


                //second matrix filled up here

                if (colCount2 != 0 && col < matrix2.GetLength(1))
                {
                    for (int row = matrix2.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix2[row, col] = counter2;
                        counter2++;
                    }

                    colCount2 = 0;
                }

            }


            //print first matrix 

            Console.WriteLine("First Matrix:");
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix1[row, col]);
                }

                Console.WriteLine();
            }

            //print second matrix //////////////

                Console.WriteLine();
                Console.WriteLine("Second Matrix:");
                for (int row1 = 0; row1 < matrix2.GetLength(0); row1++)
                {
                    for (int col1 = 0; col1 < matrix2.GetLength(1); col1++)
                    {
                        Console.Write("{0} ", matrix2[row1, col1]);
                    }

                    Console.WriteLine();

                }
            }
        }
    }


