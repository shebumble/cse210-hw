using System.Data.SqlTypes;

class SavingsAccount : Account
{
    private double _interest;

    public SavingsAccount(string name, double money) : base(name, money)
    {
        _interest = 0.0061;
    }

    public void InterestIncrease()
    {
        double money = GetMoney();
        double interest = money * _interest;
        SetMoney(interest);
    }

}