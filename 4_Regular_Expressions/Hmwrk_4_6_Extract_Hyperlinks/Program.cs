﻿using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    private static List<String> _result;

    static void Main()
    {
        _result = new List<String>();
        String input = GetInput();

        GetResults(input);
        PrintResults();
    }

    private static void PrintResults()
    {
        foreach (var i in _result)
        {
            Console.WriteLine(i);
        }
    }

    private static void GetResults(String input)
    {
        //String pat = @"\u\s;
        String pattern = @"<a.*?href\s*?=\s*?([""'])?(\S.*?)(?:>|class|\1)";
        Regex rex = new Regex(pattern);
        Match match = rex.Match(input);

        while (match.Success)
        {
            if (!(match.Groups[2].Value == "fake"))
            {
                _result.Add(match.Groups[2].Value);
            }
            match = match.NextMatch();
        }
    }

    private static String GetInput()
    {
        StringBuilder bld = new StringBuilder();
        while (true)
        {
            String input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            bld.Append(input);
            bld.Append("\n");
        }

        return bld.ToString();
    }
}