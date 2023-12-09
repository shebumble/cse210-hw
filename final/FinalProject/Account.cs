using System.Diagnostics.Contracts;
using System.Net.Http.Headers;

class Account
{
    private string _accountName;
    private double _money;

    public Account(string name, double money)
    {
        _accountName = name;
        _money = money;
    }

    public void SetMoney(double amount)
    {
        _money += amount;
    }

    public double GetMoney()
    {
        return _money;
    }

    public void Withdraw(double amount)
    {
        _money -= amount;
    }

    public string Display()
    {
        return ($"{_accountName} - ${_money}");
    }


}
