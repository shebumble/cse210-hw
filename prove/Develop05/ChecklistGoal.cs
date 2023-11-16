class ChecklistGoal : Goal

{

    private int _numberToComplete;
    private int _numberDone;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int numberToComplete, int bonusPoints) : base(name, description, points)
    {
        _numberToComplete = numberToComplete;
        _bonusPoints = bonusPoints;
        _numberDone = 0;
    }

    public ChecklistGoal(string name, string description, int points, int numberToComplete, int bonusPoints, int numberDone) : base(name, description, points)
    {
        _numberToComplete = numberToComplete;
        _bonusPoints = bonusPoints;
        _numberDone = numberDone;
    }

    public override int RecordEvent()
    {
        _numberDone += 1;
        if (_numberDone == _numberToComplete)
        {
            return _bonusPoints;
        }
        else
        {
            return GetPoints();
        }

    }

    public override bool IsComplete()
    {
        if (_numberDone >= _numberToComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void DisplayGoal()
    {
        string check;
        if (IsComplete())
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        
        Console.WriteLine($"{check} {GetName()} ({GetDescription()}) -- Currently completed {_numberDone}/{_numberToComplete}");

    }

    public override string SaveGoal()
    {
        return($"c,{GetName()},{GetDescription()},{GetPoints()},{_numberDone},{_numberToComplete},{_bonusPoints}");
    }

}