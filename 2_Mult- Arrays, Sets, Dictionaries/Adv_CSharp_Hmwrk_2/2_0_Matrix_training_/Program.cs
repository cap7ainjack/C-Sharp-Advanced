using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_0_Matrix_training_
{
    class Program
    {

        static void Main(string[] args)
        {
            // int[,] matrix= new int[3,3];

            //int[,] mymatrix =
            //{
            //    {1, 2, 3, -1},
            //    {4, 5, 6,7},
            //    {8, 88, 888,888}
            //};


            //=====================Read and write matrix===============================

            //// Read the matrix dimensions
            //Console.Write("Number of rows = ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Number of columns = ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[rows,cols];

            ////fill the matrix
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write("matrix [{0},{1}] = ",row,col);
            //        int element = int.Parse(Console.ReadLine());
            //        matrix[row, col] = element;
            //    }
            //}


            ////print the matrix

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(matrix[row,col]);
            //    }

            //    Console.WriteLine();
            //}


            // =====================fill one matrix with the same numbereverywhere
            //int rows = 3;
            //int cols = 5;
            //int[,] matrix = new int[rows,cols];
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = 10;
            //    }
            //}

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(matrix[row, col]);
            //    }

            //    Console.WriteLine();
            //}


            // ================================Fill the matrix  from the iterations of two for loops

            // int[,] array = new int[3, 4];                           // array or matrix
            // for (int row = 0; row < array.GetLength(0); row++)      // get lenght (0) doesnt means zero it means ROWS
            // {
            //     for (int col = 0; col < array.GetLength(1); col++) // get length (1) doesnt means number 1 it means Columns !
            //     {
            //         array[row, col] = row + col;                    // it si filled from the two for loops,
            //                                                         //position [row,col] = row + col (pos 0,0 = 0 + 0
            //     }                                                    //                               pos 0,1 = 0 + 1)
            // }



            //// int[,] array = new int[3, 4];                          
            // for (int row = 0; row < array.GetLength(0); row++)      // get lenght (0) doesnt means zero it means ROWS
            // {
            //     for (int col = 0; col < array.GetLength(1); col++) // get length (1) doesnt means number 1 it means Columns !
            //     {
            //         Console.Write("{0} ", array[row,col]);
            //     }

            //     Console.WriteLine();
            // }



            //==============================MAtrix Platform================

            //int[,] matrix =
            // {
            //    { 0, 2, 4, 0, 9, 5 },
            //    { 7, 1, 3, 3, 2, 1 },
            //    { 1, 3, 9, 8, 5, 6 },
            //    { 4, 6, 7, 9, 1, 0 }
            //};

            //int bestSum = int.MinValue;
            //int bestRow = 0;
            //int bestCol = 0;
            //for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            //    {
            //        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

            //        if (sum > bestSum)
            //        {
            //            bestSum = sum;
            //            bestRow = row;
            //            bestCol = col;
            //        }
            //    }
            //}

            ////print result
            //Console.WriteLine("The best platform is: ");
            //Console.WriteLine("  {0}  {1}", matrix[bestRow,bestCol], matrix[bestRow,bestCol+1]);
            //Console.WriteLine("  {0}  {1}", matrix[bestRow+1,bestCol],matrix[bestCol+1,bestCol+1]);
            //Console.WriteLine("The maximum sum is {0}",bestSum);


            // ========================Matrix Multiplication=================

            //    int[,] matrix1 =
            //    {
            //        {1, 2 },
            //        {3, 4 }
            //    };

            //    int[,] matrix2 =
            //    {
            //        {5, 6},
            //        {7, 8}
            //    };


            //    int columns1 = matrix1.GetLength(1);
            //    int rows1 = matrix1.GetLength(0);
            //    int columns2 = matrix2.GetLength(1);
            //    int rows2 = matrix2.GetLength(0);

            //    if (rows1 != columns2)
            //    {
            //        throw new ArgumentException("Invalid dimensions!");
            //    }

            //    int[,] sum = new int[rows1,columns2];

            //    for (int row = 0; row < rows1; row++)
            //    {
            //        for (int col = 0; col < columns2; col++)
            //        {
            //            sum[row, col] = 0;

            //            for (int i = 0; i < columns1; i++)
            //            {
            //                sum[row,col] += matrix1[row, i]*matrix2[i,col] ;
            //            }


            //        }
            //    }

            //    // Print the result matrix
            //    for (int row = 0; row < sum.GetLength(0); row++)
            //    {
            //        for (int col = 0; col < sum.GetLength(1); col++)
            //        {
            //            Console.Write("{0} ", sum[row, col]);
            //        }

            //        Console.WriteLine();
            //    }

            //    Console.WriteLine();





            //======================Jagged arrays==========================

            //int[][] jagged = new int[3][];
            //jagged[0] = new int[3];
            //jagged[1] = new int[2];
            //jagged[2] = new int[5];


            ////////////////////// FILL jagged array
            /// 
            //int[][] jagged = new int[5][];

            //for (int i = 0; i < jagged.GetLength(0); i++)
            //{
            //    string[] inputNumbers = Console.ReadLine().Split(' ');
            //    jagged[i] = new int[inputNumbers.Length];                //always must be initilize the size of the new array !

            //    for (int j = 0; j < jagged.GetLength(1); j++)
            //    {
            //        jagged[i][j] = int.Parse(inputNumbers[j]);
            //    }
            //}
            

  
        }
    }
}
