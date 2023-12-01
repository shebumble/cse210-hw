using System.Globalization;

class CreditCard : Card
{
    private Bill _bill;
    private double _minimum;

    public CreditCard(int number, string expiry, double minimum) : base(number, expiry)
    {
        _minimum = minimum;
    }

    public override void ChargeCard()
    {
        
    }
}