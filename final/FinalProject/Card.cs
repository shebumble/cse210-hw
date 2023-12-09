abstract class Card
{
    private string _number;
    private string _expiry;

    public Card(string number, string expiry)
    {
        _number = number;
        _expiry = expiry;
    }

    public abstract void ChargeCard(double amount, Account account);

    public abstract string Display();

    public string GetNumber()
    {
        return _number;
    }

    public string GetExpiry()
    {
        return _expiry;
    }

    public abstract string GetType();

}