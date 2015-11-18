using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter_May_2015
{
    class Program
    {
        static void Main()
        {
            string[] numbersInput =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                try
                {
                    var CurrentCommand = commands.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (CurrentCommand[0])
                {
                    case "reverse":
                        string actionReverse = "reverse";
                        CommandReverseOrSort(numbersInput, CurrentCommand, actionReverse);
                        break;

                    case "sort":
                        string actionSort = "Sort";
                        CommandReverseOrSort(numbersInput, CurrentCommand, actionSort);
                        break;

                    case "rollLeft":
                        CommandRollLeft(numbersInput, CurrentCommand);
                        break;

                    case "rollRight":
                        CommandRollRight(numbersInput, CurrentCommand);
                        break;
                }

                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input parameters.");
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ",numbersInput) + "]");
        }

        private static void CommandRollRight(string[] numbers, string[] command)
        {

            string lastnum = numbers[numbers.Length - 1];
            int count = int.Parse(command[1]);

            for (int i = 0; i < count; i++)
            {
                List<string> RollToRightList = new List<string>();

                RollToRightList.Add(lastnum);

                for (int j = 0; j < numbers.Length - 1; j++)
                {

                    RollToRightList.Add(numbers[j]);
                }

                lastnum = RollToRightList[RollToRightList.Count - 1];

                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = RollToRightList[j];
                }
            }
            
        }

        private static void CommandRollLeft(string[] numbers, string[] command)
        {

            string firstNum = numbers[0];
            int count = int.Parse(command[1]);

            for (int i = 0; i < count; i++)
            {
                List<string> RolledToLeftList = new List<string>();
                for (int j = 1; j < numbers.Length; j++)
                {
                    RolledToLeftList.Add(numbers[j]);
                }
                RolledToLeftList.Add(firstNum);

                firstNum = RolledToLeftList[0];

                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = RolledToLeftList[j];
                }
            }
        }

        private static void CommandReverseOrSort(string[] numbers, string[] command, string action)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);

            if (start < 0 || count <= start )
            {
                throw new ArgumentException();
            }
            List<string> numsForReverse = new List<string>();
            for (int i = start; i < count + start; i++)
            {
                numsForReverse.Add(numbers[i]);
            }

            if (action == "reverse")
            {
                numsForReverse.Reverse();
            }
            else
            {
                numsForReverse.Sort();
            }

            for (int i = start, j = 0; i < count + start; j++, i++)
            {
                numbers[i] = numsForReverse[j];
            }

        }


    }
}
