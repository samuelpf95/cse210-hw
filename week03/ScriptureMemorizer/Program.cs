using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int index = rnd.Next(3);
        Reference reference = new Reference();
        string refe= reference.GetRef(index);
        Scripture scripture = new Scripture();
        string script = scripture.GetScript(index);
        string ans;
        Words word = new Words(script);
        List<string> words = word.GetWords();
        do{
            Console.Clear();
            Console.Write(refe + ": ");
            foreach (var w in words)
            {
                Console.Write(w + " ");
            }
            Console.WriteLine("\n\n");
            if (word.Hidden())
            {
                Console.Write("Press Enter or type 'Quit' to finish:");
            }
            else
            {
                Console.Write("Press Enter to continue or type 'Quit' to finish:");
            }
            ans = Console.ReadLine();
            if (ans != "quit" && ans != "Quit" && ans != "QUIT")
            {
                if (word.Hidden())
                {
                    break;
                }
                else
                {
                    word.Hide();
                }
            }
        }while (ans != "quit");
    }
}
//Included 3 scriptures wich are randomly selected at the start of the program
//When every word is hidden, the instructions change according to the behavior of the program
//It supports "quit", "Quit", and "QUIT" as valid answer 