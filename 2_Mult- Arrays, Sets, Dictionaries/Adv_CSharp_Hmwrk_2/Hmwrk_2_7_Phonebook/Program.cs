using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_2_7_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phonebook = new Dictionary<string, string>();

            string[] input = new string[2];

            Console.WriteLine("Enter name and number ('Name-Number'): ");
            input = Console.ReadLine().Split('-').ToArray();


            while (!(input[0] == "search"))
            {
                try
                {
                    phonebook.Add(input[0], input[1]);
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid output");
                    ;
                }

                input = Console.ReadLine().Split('-').ToArray();
            }


            if (input[0] == "search")
            {
                do
                {
                    string name = Console.ReadLine();

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
          
                    }

                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist");
                    }
                    

                } while (true);
               
            }


        }
    }
}
