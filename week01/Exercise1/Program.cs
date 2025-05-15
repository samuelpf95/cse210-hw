using System;

class Program
{
    static void Main(string[] args)
    {
        string fn, ln;
        Console.WriteLine("What is your first name?");
        fn=Console.ReadLine();
        Console.WriteLine("What is your last name?");
        ln=Console.ReadLine();
        Console.WriteLine($"Your name is {ln}, {fn} {ln}");
    }
}