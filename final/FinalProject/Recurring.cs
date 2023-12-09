using System.Runtime.CompilerServices;

class Recurring : Bill
{
    private int _timesCharged;
    private int _timesPaid;
    public Recurring(string description, double due) : base(description, due)
    {
        _timesCharged = 1;
        _timesPaid = 0;
    }

    public override string Display()
    {
        string description = GetDescription();
        double d = GetDue();
        double p = GetPaid();
        double diff = GetDifference();
        bool x = PaidFull();

        return ($"[ ] {description} - ${p}/${d} paid {_timesPaid}/{_timesCharged} times, with ${diff} still owed.");
    }

    public override void MakePayment(double amount)
    {
        _timesPaid += 1;
        SetPaid(amount);
    }

    public override bool PaidFull()
    {
        return true;
    }

    public override void Charge()
    {
        _timesCharged += 1;
        double d = GetDue();
        SetDue(d);
    }

    public override string GetType()
    {
        return ("Rec");
    }
}