using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

public abstract class Goal

{
    private string _name;
    private string _description;
    private int _points;

    


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract void DisplayGoal();

    public abstract bool IsComplete();

    public abstract string SaveGoal();

    public int GetPoints()
    {
        return _points;
    }


    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }

}
