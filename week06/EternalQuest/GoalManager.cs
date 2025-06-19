using System;
using System.Collections.Generic;
using System.IO; 
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }

    public void Start()
    {
        int ans;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            ans = int.Parse(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    DisplayListGoal();
                    break;
                case 3:
                if (_goals.Count==0)
                    {
                        Console.WriteLine("\nNo goals yet!");
                        break;
                    }
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    if (_goals.Count==0)
                    {
                        Console.WriteLine("\nNo goals yet!");
                        break;
                    }
                    RecordEvent();
                    break;
            }
        } while (ans != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have: {_score} points.\n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;

        if (type == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (type == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }
        _goals.Add(newGoal);
    }

    public void DisplayListGoal()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count==0)
        {
            Console.WriteLine("\nNo goals yet!");
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        DisplayListGoal();

        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!\nYou now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("\nWrite the name of the document without extension (like .txt): ");
        string input = Console.ReadLine();
        string filename = input + ".txt";

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals successfully saved. Press Enter to continue");
        Console.ReadLine();
    }
    public void LoadGoals()
    {
        Console.Write("\nWrite the name of the document without extension (like .txt): ");
        string input = Console.ReadLine();
        string filename = input + ".txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Press Enter to continue");
            Console.ReadLine();
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');

            string goalType = parts[0];
            string data = parts[1];

            Goal goal = null;

            switch (goalType)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(data);
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(data);
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(data);
                    break;
            }
            _goals.Add(goal);
        }
        Console.WriteLine("Goals successfully loaded. Press Enter to continue");
        Console.ReadLine();
    }

}
