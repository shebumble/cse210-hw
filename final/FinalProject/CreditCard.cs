using System.Globalization;

class CreditCard : Card
{
    private Bill _bill;
    private double _minimum;
    private double _owed;

    public CreditCard(string number, string expiry, double minimum) : base(number, expiry)
    {
        _minimum = minimum;
        _owed = 0;
    }

    public override void ChargeCard(double amount, Account account)
    {
        _owed += amount;
    }

    public override string Display()
    {
        string n = GetNumber();
        string e = GetExpiry();
        return ($"Credit ***{n} Expires: {e} Minimum: {_minimum} Owed: {_owed}");
    }

    public override string GetType()
    {
        return("Credit");
    }

}