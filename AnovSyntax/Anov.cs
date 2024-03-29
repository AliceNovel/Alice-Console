﻿using System.Text.RegularExpressions;

namespace AnovSyntax;

public class Anov
{
    public static void Read(string str)
    {
        Match match;

        // Read "- people-name"
        match = Regex.Match(str, @"- (.*)");
        if (match.Success)
            Console.Write(match.Groups[1].Value);

        // Read "[conversatioc-content]"
        match = Regex.Match(str, @"\[(.*?)\]");
        if (match.Success)
            Console.WriteLine(" \"" + match.Groups[1].Value + "\"");
    }
}
