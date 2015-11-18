using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_6_4
{
    class Program
    {
        const string sourceFile = "../../origintextfile.txt";
        const string desination = "../../";

        static void Main(string[] args)
        {
      

            Console.WriteLine("Enter number of parts to be sliced");
            int parts = int.Parse(Console.ReadLine());

            SplitFiles(parts);
            Assemble(parts);

        }


        private static void SplitFiles(int parts)
        {
            byte[] buffer = new byte[4096];

            using (Stream input = File.OpenRead(sourceFile))
            {
                
            }
        }


        private static void Assemble(int parts)
        {
            throw new NotImplementedException();
        }

      
    }
}
