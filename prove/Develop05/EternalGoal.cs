class EternalGoal : Goal

{
    int _timesDone;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesDone = 0;
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
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
        return($"e,{GetName()},{GetDescription()},{GetPoints()}");
    }

}