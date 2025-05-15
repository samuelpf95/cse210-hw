using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int ans, sum = 0, largest = 0, count= 0;
        float avg;
        string input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            ans = int.Parse(input);
            if (ans != 0)
            {
                numbers.Add(ans);
                count+=1;
            }
        }while (ans!=0);
        foreach (int number in numbers)
        {
            sum = sum + number;
            if (largest<number)
            {
                largest=number;
            }
        }
        avg=sum/count;        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}