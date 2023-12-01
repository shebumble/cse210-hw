using System.Runtime.CompilerServices;

class Recurring : Bill
{
    private int _timesCharged;
    private int _timesPaid;
    public Recurring(string description, double due) : base(description, due)
    {
        _timesCharged = 0;
        _timesPaid = 0;
    }

    public override string Display()
    {
        return "";
    }

    public override void MakePayment()
    {
        
    }

    public override bool PaidFull()
    {
        return true;
    }

    public void Chaarge()
    {
        
    }
}