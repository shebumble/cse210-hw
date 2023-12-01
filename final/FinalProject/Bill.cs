using System.ComponentModel.DataAnnotations;

abstract class Bill
{
    private string _description;
    private double _due;
    private double _paid;

    public Bill(string description, double due)
    {
        _description = description;
        _due = due;
    }

    public abstract string Display();
    public abstract void MakePayment();
    public abstract bool PaidFull();
}