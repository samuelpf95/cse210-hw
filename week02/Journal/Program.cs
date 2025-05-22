using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("What would you like to do? ");
        int ans= Menu();        
        while (ans != 5)
        {
            if (ans == 1)
            {
                journal.AddEntry();
            }
            else if (ans == 2)
            {
                journal.DisplayEntry();
            }
            else if (ans == 3)
            {
                journal.LoadDoc();
            }
            else if (ans == 4)
            {
                journal.WriteDoc();
            }
        Console.WriteLine("\nWhat else do you want to do?");
        ans = Menu();
        }
    }
    static int Menu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string input = Console.ReadLine();
        int ans = int.Parse(input);
        return ans;
    }
}
//Added a verification if the user enters a file name that doesn't exists
//The Journal also creates a CSV file with the entries when saving