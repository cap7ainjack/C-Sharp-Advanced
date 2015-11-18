using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_6_2
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../NewText.txt"))
            {
                using (var writer = new StreamWriter("../../LatestTxt.txt"))
                {
                    string line = reader.ReadLine();

                 //   while (line != null)
                   // {
                        for (int i = 0; line != null; i++)
                        {
                            writer.WriteLine("{0}. {1}",i,line);
                            Console.WriteLine(line);
                            line = reader.ReadLine();
                        }

                       
                    //}
                }
            }
        }
    }
}
