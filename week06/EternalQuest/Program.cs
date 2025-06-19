using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager program = new GoalManager();
        program.Start();
    }
}
//added verification when no goals are saved and user wants to list goals or record events, when no text file is found and when user wants to save an empty file