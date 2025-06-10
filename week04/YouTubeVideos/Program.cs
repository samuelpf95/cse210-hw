using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("**Here is the analysis for today's three more relevant videos:**\n");
        Video videoA = new Video(); 
        Video videoB = new Video(); 
        Video videoC = new Video(); 
        Console.WriteLine(videoA.GetStats());
        Console.WriteLine("Comments:");
        videoA.PrintComments();
        Console.WriteLine(videoB.GetStats());
        Console.WriteLine("Comments:");
        videoB.PrintComments();
        Console.WriteLine(videoC.GetStats());
        Console.WriteLine("Comments:");
        videoC.PrintComments();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}