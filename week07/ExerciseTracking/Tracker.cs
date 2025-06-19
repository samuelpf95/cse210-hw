public class Tracker
{
    private List<Activity> _activities;

    public Tracker()
    {
        _activities = new List<Activity>();
    }

    public void LoadSampleData()
    {
        _activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        _activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 12.0));
        _activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));
    }

    public void ShowSummaries()
    {
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}