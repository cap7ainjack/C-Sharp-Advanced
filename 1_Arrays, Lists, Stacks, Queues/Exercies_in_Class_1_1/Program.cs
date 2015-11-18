using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_in_Class_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {};
            //int max = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }

            //    //var reversed = nums.Reverse();
            //    //Console.WriteLine(string.Join(",", reversed));

            //    //convertall - convert all elements in 'nums' from positive to negative nums
            //    Array.ConvertAll(nums, p => -p);


// =====================bubble method=======================

        //    string array = Console.ReadLine();
        //    string[] items = array.Split(' ');


        //    int[] numbers = new int[items.Length];
            
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = int.Parse(items[i]);
        //    }

        //    bool swapped = false;

        //    do
        //    {
        //        swapped = false;
        //        for (int i = 0; i < numbers.Length - 1; i++)
        //        {
        //            if (numbers[i] > numbers[i+1])
        //            {
        //                int temp = numbers[i];
        //                numbers[i] = numbers[i + 1];
        //                numbers[i + 1] = temp;

        //                swapped = true;
        //            }
        //        }
        //    } while (swapped == true);


        //    Console.WriteLine(string.Join(",",numbers));
       


      // =================== Join lists =============

        string array = Console.ReadLine();
        string second_array = Console.ReadLine();
        string[] items = array.Split(' ');
        string[] second_items = second_array.Split(' ');


            //int[] numbers = new int[items.Length];
            //int[] second_numbers = new int[second_items.Length];        

        List<string> numbers = new List<string>();
        List<string> second_numbers = new List<string>();


            for (int i = 0; i < items.Length; i++)
            {
                numbers.Add(items[i]);
            }

            numbers.Select(int.Parse).ToList();

            for (int i = 0; i < items.Length; i++)
            {
                second_numbers.Add(items[i]);
            }

            second_numbers.Select(int.Parse).ToList();


        }
        }
    }


