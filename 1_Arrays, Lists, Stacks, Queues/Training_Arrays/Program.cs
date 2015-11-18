using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Training
    {
        private static void Main(string[] args)
        {
            // sum of numbers taken fom array input and splited by " "

            string arrString = Console.ReadLine();

            string[] items = arrString.Split(new char[] { ' ' },   // removes empty entries,
                StringSplitOptions.RemoveEmptyEntries);         // EX: if there are two spaces instead of one between the numbers

            int[] numbers = new int[items.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            Console.WriteLine(numbers.Sum());



            // ================== how to output string: they are 3 ways - for loop, foreach loop and Join method

            string[] strings = new string[]
            {
                    "First string",
                    "Second string",
                    "Varna"
            };

            // first way
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.WriteLine(strings[i]);
            //}

            //second way
            //foreach (var s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            //third way
            string str = string.Join(",", strings);
            Console.WriteLine(str);





            //================== find squares of array of numbers (squeare for each number)

            int[] array = { 2, 3, 4 };
            int[] squares = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                squares[i] = array[i] * array[i];
            }

            Console.WriteLine(string.Join(",", squares));


            //================ array of anonomouis objects

            var arr = new[]
            {
                new { Name="Pesho", age= 15},
                new { Name="Gosho", age=22},
                new { Name="Maria", age=18}
            };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            //=======================Lists====

            //--------

            List<int> nums = new List<int>(1000) {10,20,30,40, 50, 60, 70, 80};
            // nums.removeAll (p => p <= 1000)  - removes all that are lower than 1000

            // var results = nums.where(i => i % 2 == 0 )

            // var results = nums.forEach(p => console.Writeline(p))

            var result = nums.Take(2); // takes the first two
            var result1 = nums.Skip(3).Take(2); // skip first 3 and show me the two after them
            var result2 = nums.Skip(3).Take(2).ToArray(); // skip first 3 and show me the two after them as an array

            //-----------





            // object lists or anonomys list 

            List<object> list = new List<object>
            {
                "Pesho",
                "Gosho",
                "Maria",
                5,
                new DateTime(2015, 1, 1)

            };


            //print it on the console - functional way
            list.ForEach(i => Console.WriteLine(i));

            //add range

            List<int> intItems = new List<int>();
            intItems.AddRange(new int[] { 4, 5, 6 });

            //index of
            Console.WriteLine(intItems.IndexOf(5)); // show on which postions we have the int '5'

            // count how many '5' we have in the list - functional way
            Console.WriteLine(intItems.Count(p => p == 5));

            //count how many '5' we have in the list with loop

            int count = 0;
            int startIndex = -1;
            while (true)
            {
                startIndex = intItems.IndexOf(4, startIndex + 1);
                if (startIndex == -1)
                {
                    break;
                }
                count++;
            }


            // reverse the list

            intItems.Reverse();


            ////////min max sum (list)

            List<int> lista = new List<int>() { 3, 4, 5 };
            Console.WriteLine("Sum = {0}", lista.Sum());
            Console.WriteLine("Min = {0}", lista.Min());
            Console.WriteLine("Max = {0}", lista.Max());

            Console.WriteLine(lista.Skip(2).FirstOrDefault()); // sskip number on the second position

            // Distinct()  -removes the ones that repeat

            //========================Stack==============

            //stack keeps all the added items in the opposite order:

            Stack<string> stack = new Stack<string>();
            stack.Push("Възглавничка синя");
            stack.Push("одеало");
            stack.Push("зелен чаршав");
            stack.Push("голяма възглавница");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            //output will be:
            //голяма възглавница
            //зелен чаршав
            //одеало...




         //queue

               var queue = new Queue<string>();

            queue.Enqueue("Mimi");
            queue.Enqueue("Ani");
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("Didi");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }



            ////
            /// 

            var ints = new int[] {1, 2, 3, 4, 5};

            var result123 = ints.Distinct(); // mahni ednakvite

            Console.WriteLine(ints.Where(p=> p % 2 == 0)); // pokaji chetnite







  //===============Dictionary========================








        }
    }
}

