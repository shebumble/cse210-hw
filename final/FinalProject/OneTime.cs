class OneTime : Bill
{
    public OneTime(string description, double due) : base(description, due)
    {

    }

    public override string Display()
    {
        string description = GetDescription();
        double d = GetDue();
        double p = GetPaid();
        double diff = GetDifference();
        bool x = PaidFull();
        string complete;

        if (x == true)
        {
            complete = "[X]";
        }
        else
        {
            complete = "[ ]";
        }

        return ($"{complete} {description} - ${p}/${d} with ${diff} still owed.");
    }

    public override void MakePayment(double amount)
    {
        SetPaid(amount);
    }

    public override bool PaidFull()
    {
        double d = GetDue();
        double p = GetPaid();
        if (p >= d)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetType()
    {
        return ("One");
    }

    public override void Charge()
    {
        
    }
}