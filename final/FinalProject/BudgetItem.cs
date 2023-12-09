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
        _used = 0;
    }

    public void RecordPayment(double payment)
    {
        _used += payment;
    }

    public string Display()
    {
        SetDifference();
        return ($"{_category} - ${_budget}: You have used ${_used}, this is a difference of ${_difference}");
    }

    private void SetDifference()
    {
        _difference = _budget - _used;
    }

    public string GetCategory()
    {
        return _category;
    }

    public void SetUsed(double used)
    {
        _used += used;
    }
}