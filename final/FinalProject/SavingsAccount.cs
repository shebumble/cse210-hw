class SavingsAccount : Account
{
    private double _interest;

    public SavingsAccount(string name, double money, double interest) : base(name, money)
    {
        _interest = interest;
    }

    public void InterestIncrease()
    {

    }

    public double InterestPredict(int time)
    {
        return (0.00);
    }
}