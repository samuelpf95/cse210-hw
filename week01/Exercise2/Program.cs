using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Enter your grade");
        input=Console.ReadLine();
        int g=int.Parse(input);
        if (g<60)
        {
            Console.WriteLine("Your grade is F, you failed");
        }
        else if (g>=60 && g<70)
        {
            Console.WriteLine("Your grade is D, you failed");
        }
        else if (g>=70 && g<80)
        {
            Console.WriteLine("Your grade is C, you passed!");
        }
        else if (g>=80 && g<90)
        {
            Console.WriteLine("Your grade is B, you passed!");
        }
        else if (g>=90)
        {
            Console.WriteLine("Your grade is A, you passed!");
        }
    }
}