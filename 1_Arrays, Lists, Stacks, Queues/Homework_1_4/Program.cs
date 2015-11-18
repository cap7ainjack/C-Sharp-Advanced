using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_4
{
    class Hmwrk_1_4
    {
        static void Main(string[] args)
        {
            //string array = Console.ReadLine();
            //string[] inputWords = array.Split(new char[] { ' ' },
            //    StringSplitOptions.RemoveEmptyEntries);

            //Dictionary<String, int> allWords = new Dictionary<string, int>();

            //for (int i = 0; i < inputWords.Length; i++)
            //{
            //    String currentWord = inputWords[i];

            //    if (!allWords.ContainsKey(currentWord))
            //    {
            //        allWords.Add(currentWord, 1);     // add the word to the dictionary
            //    }
            //    else
            //    {
            //        allWords[currentWord]++;    // founded a word that is already in dictionary, add value 
            //    }
            //}

            //StringBuilder result = new StringBuilder();

            //foreach (var word in allWords)
            //{
            //    for (int j = 0; j < word.Value; j++)
            //    {
            //        result.Append(word.Key + " ");      //add word to result as many times as the word value
            //    }

            //    // result.Length--;       
            //    result.AppendLine(); //newline
            //}

            //Console.WriteLine(result.ToString().TrimEnd());




            int i;
            string[] inputString = Console.ReadLine().Split(' ');
            for (i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {
                    Console.Write("{0} ", inputString[i]);
                }
                else
                {
                    Console.WriteLine("{0}", inputString[i]);
                }
            }
            Console.WriteLine("{0}", inputString[i]);

        }
    }
}
