using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        Console.WriteLine("What is the magic number?");
        input=Console.ReadLine();
        int mn = int.Parse(input);
        int guess;
        do
        {
            Console.WriteLine("What is your guess?");
            input=Console.ReadLine();
            guess = int.Parse(input);
            if (mn==guess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (mn>guess)
            {
                Console.WriteLine("Higher");
            }
            else if (mn<guess)
            {
                Console.WriteLine("Lower");
            }
        }while (guess!=mn);

    }
}