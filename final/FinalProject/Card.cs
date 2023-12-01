abstract class Card
{
    private int _number;
    private string _expiry;

    public Card(int number, string expiry)
    {

    }

    public abstract void ChargeCard();

    public void IsExpired()
    {
        
    }
}