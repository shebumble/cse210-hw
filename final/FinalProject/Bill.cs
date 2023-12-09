using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

abstract class Bill
{
    private string _description;
    private double _due;
    private double _paid;

    public Bill(string description, double due)
    {
        _description = description;
        _due = due;
        _paid = 0;
    }

    public abstract string Display();
    public abstract void MakePayment(double amount);
    public abstract bool PaidFull();
    public abstract void Charge();

    public string GetDescription()
    {
        return _description;
    }

    public double GetDue()
    {
        return _due;
    }

    public void SetDue(double amount)
    {
        _due += amount;
    }

    public void SetPaid(double amount)
    {
        _paid += amount;
    }

    public double GetPaid()
    {
        return _paid;
    }

    public double GetDifference()
    {
        return (_due - _paid);
    }

    public abstract string GetType();
}