using System;

class Program
{
    static int totalActivitiesDone = 0;

    static void Main(string[] args)
    {
        int ans = Menu();
        while (ans != 5)
        {
            switch (ans)
            {
                case 1:
                    BreathingActivity breath = new BreathingActivity();
                    breath.Run();
                    totalActivitiesDone++;
                    break;
                case 2:
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                    totalActivitiesDone++;
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    totalActivitiesDone++;
                    break;
                case 4:
                    Console.WriteLine($"\nYou have completed {totalActivitiesDone} activities.\n");
                    Console.WriteLine("Press enter to return to the menu...");
                    Console.ReadLine();
                    break;
            }
            ans = Menu();
        }

        Console.WriteLine("Goodbye!");
    }

    static int Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Show completed activity count");
        Console.WriteLine(" 5. Quit");
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
}
//Added a count that keeps track of the amount of finished activities