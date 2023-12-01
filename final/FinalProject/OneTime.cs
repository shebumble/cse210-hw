class OneTime : Bill
{
    public OneTime(string description, double due) : base(description, due)
    {

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

    public double GetDifference()
    {
        return (0.00);
    }
}