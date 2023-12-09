class DebitCard : Card
{
    public DebitCard(string number, string expiry) : base(number, expiry)
    {
        
    }

    public override void ChargeCard(double amount, Account account)
    {
        account.Withdraw(amount);
    }

    public override string Display()
    {
        string n = GetNumber();
        string e = GetExpiry();
        return ($"Debit ***{n} Expires: {e}");
    }

    public override string GetType()
    {
        return("Debit");
    }
}