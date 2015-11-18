using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var reader = new StreamReader("../../NewText.txt"))
            {
                string line = reader.ReadLine();

                for (int i = 0; line != null; i++)
                {
                  
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }

                //int counter = 0;
                //while (line != null)
                //{
                //    if (counter % 2 != 0)
                //    {
                //        Console.WriteLine(line);
                //   }
                //    counter++;

                //    line = reader.ReadLine();
           //     }
        }
        }
    }
}
