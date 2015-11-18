using System;
using System.Collections.Generic;
using System.Linq;


namespace Hmwrk_2_4_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //string[,] matrix = new string[n,m];

            //Console.WriteLine("Enter the strings in each row, separated by a space.");
            //for (int i = 0; i < n; i++)
            //{
            //    string[] rowStrins = Console.ReadLine().Split(' ').ToArray();
            //    for (int j = 0; j < m; j++)
            //    {
            //        matrix[i, j] = rowStrins[j];
            //    }
            //}
            //string[,] matrix =
            //{
            //    { "ha", "hihi", "ho", "hi"},
            //    {"fo", "ha", "hi", "xx" },
            //    {"xxx", "ho", "ha", "xx" }
            //};

            string[,] matrix =
            {
                {"s", "qq", "s" },
                {"pp", "pp", "s" },
                {"pp", "qq", "s" }
            };


            Dictionary<string,int> allWords = new Dictionary<string, int>();


            // create 2x2 platform

            int platformRows = 2;
            int platformCols = 2;

            for (int row = 0; row <= matrix.GetLength(0) - platformRows ; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - platformCols; col++)
                {
              
                    // 1   they are 6 if`s for each platform position, checking  all the four elements if there are equals between them
                    if (matrix[row,col] == matrix[row,col+1])
                    {
                        string currWord = matrix[row, col];
                        if (!(allWords.ContainsKey(currWord)))
                        {
                            allWords.Add(currWord,1);
                        }
                        else
                        {
                            allWords[currWord]++;
                        }
                    }

                    //2
                    if (matrix[row, col] == matrix[row+1, col])
                    {
                        string curWord = matrix[row, col];
                        if (!(allWords.ContainsKey(curWord)))
                        {
                            allWords.Add(curWord, 1);
                        }
                        else
                        {
                            allWords[curWord]++;
                        }
                    }

                    //3
                    if (matrix[row, col] == matrix[row + 1, col+1])
                    {
                        string curWord = matrix[row, col];
                        if (!(allWords.ContainsKey(curWord)))
                        {
                            allWords.Add(curWord, 1);
                        }
                        else
                        {
                            allWords[curWord]++;
                        }
                    }


                    //4
                    if (matrix[row+1, col] == matrix[row, col+1])
                    {
                        string curWord = matrix[row+1, col];
                        if (!(allWords.ContainsKey(curWord)))
                        {
                            allWords.Add(curWord, 1);
                        }
                        else
                        {
                            allWords[curWord]++;
                        }
                    }

                    //5
                    if (matrix[row + 1, col] == matrix[row+1, col + 1])
                    {
                        string curWord = matrix[row+1, col];
                        if (!(allWords.ContainsKey(curWord)))
                        {
                            allWords.Add(curWord, 1);
                        }
                        else
                        {
                            allWords[curWord]++;
                        }
                    }

                    //6
                    if (matrix[row, col+1] == matrix[row + 1, col + 1])
                    {
                        string curWord = matrix[row, col+1];
                        if (!(allWords.ContainsKey(curWord)))
                        {
                            allWords.Add(curWord, 1);
                        }
                        else
                        {
                            allWords[curWord]++;
                        }
                    }

                }
            }
            
            //print the result

           // var max = results.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            var biggestSeq = allWords.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var biggestSeqCount = allWords.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;

          //  Console.WriteLine("{0}, {1}",biggestSeq,biggestSeqCount);

            for (int i = 0; i < biggestSeqCount+1; i++)
            {
                Console.Write("{0}, ", biggestSeq);
            }
            
        }
    }
}
