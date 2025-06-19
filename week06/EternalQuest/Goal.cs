public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public Goal() 
    { 
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetShortName(string name)
    {
        _shortName = name;
    }
    public void SetDescription(string desc)
    {
        _description = desc;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public virtual string GetDetailsString()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}