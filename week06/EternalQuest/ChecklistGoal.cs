public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string data)
        : base()
    {
        string[] parts = data.Split(',');
        SetShortName(parts[0]);
        SetDescription(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _amountCompleted = int.Parse(parts[3]);
        _target = int.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
    {
        return GetPoints() + _bonus;
    }
    else if (_amountCompleted < _target)
    {
        return GetPoints();
    }
    else
    {
        return 0;
    }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
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

        return checkbox + " " + GetShortName() + " (" + GetDescription() + ") -- Completed: " + _amountCompleted + "/" + _target;
    }
    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:" + GetShortName() + "," + GetDescription() + "," + GetPoints() + "," + _amountCompleted + "," + _target + "," + _bonus;
    }
    public int GetBonusIfComplete()
    {
        if (IsComplete() && _amountCompleted == _target)
        {
            return _bonus;
        }
        else
        {
            return 0;
        }
    }
}
