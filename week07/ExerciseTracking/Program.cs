using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(new DateTime(2025, 1, 30), 30, 8);
        Cycling cycle = new Cycling(new DateTime(2024, 5, 15), 50, 6);
        Swimming swim = new Swimming(new DateTime(2025, 6, 19), 80, 4);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}