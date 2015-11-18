using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clean_Up_the_mess
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string pattern = @"(\s*.+)?(\s*\n\s*)*";

            string text = File.ReadAllText("../../Mecanismo.cs");

            Regex newLinesRegex = new Regex(pattern);

           // MatchCollection newLinesMatches = newLinesRegex.Matches(text);

            string whaaat = Regex.Replace(text, pattern, "@@@@@@@");
            Console.WriteLine(whaaat);


        }
    }
}
