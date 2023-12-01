using System.ComponentModel.DataAnnotations;
using System.Reflection;

class BudgetItem 
{
    private string _category;
    private double _budget;
    private double _used;
    private double _difference;

    public BudgetItem(string category, double budget)
    {
        _category = category;
        _budget = budget;
    }

    public void RecordPayment(double payment)
    {

    }

    public string Display()
    {
        return "";
    }

    private void SetDifference()
    {

    }

    public double GetDifference()
    {
        return _difference;
    }
}