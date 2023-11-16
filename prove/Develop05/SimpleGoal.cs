class SimpleGoal : Goal

{
    int _timesDone;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesDone = 0;
    }

    public SimpleGoal(string name, string description, int points, int timesDone) : base(name, description, points)
    {
        _timesDone = timesDone;
    }

    public override int RecordEvent()
    {
        _timesDone = 1;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        if (_timesDone >= 1)
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
        
        Console.WriteLine($"{check} {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return($"s,{GetName()},{GetDescription()},{GetPoints()},{_timesDone}");
    }

}