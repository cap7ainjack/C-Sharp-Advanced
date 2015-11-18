using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            string snake = Console.ReadLine();
            string[] shot = Console.ReadLine().Split();

            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);

            int impactRow = int.Parse(shot[0]);
            int impactCol = int.Parse(shot[1]);
            int radius = int.Parse(shot[2]);

            char[,] matrix = new char[rows,columns];

            FillMatrix(matrix, snake);

            FireAShot(matrix, impactRow, impactCol, radius);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                RunGravity(matrix, col);
            }

            PrintMatrix(matrix);
        }

        private static void RunGravity(char[,] matrix, int col)
        {
            while (true)
            {
                bool hasFallen = false;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    char topChar = matrix[row - 1, col];
                    char currentChar = matrix[row, col];
                    if (currentChar == ' ' && topChar != ' ')
                    {
                        matrix[row, col] = topChar;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }

                if (!hasFallen)
                {
                    break;
                }
            }
        }

        private static void FireAShot(char[,] matrix, int impactRow, int impactCol, int radius)
        {
            double diameter = radius*radius;
            int h1 = impactRow;
            int h2 = impactCol;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (((row - h1) * (row - h1) + (col - h2) * (col - h2)) <=diameter)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void FillMatrix(char[,] matrix, string snake)
        {
            int snakeCounter = 0;
            bool toLeft = true;

            for (int row = matrix.GetLength(0) -1; row >=0 ; row--)
            {
                if (toLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (snakeCounter >= snake.Length)
                        {
                            snakeCounter = 0;
                        }
                        matrix[row, col] = snake[snakeCounter];
                        snakeCounter++;
                    }
                    toLeft = false;
                }

                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (snakeCounter >= snake.Length)
                        {
                            snakeCounter = 0;
                        }

                        matrix[row, col] = snake[snakeCounter];
                        snakeCounter++;
                    }

                    toLeft = true;
                }
                
            }

        }

        private static void PrintMatrix(char[,] matrix)
        {
            // Print the result matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

