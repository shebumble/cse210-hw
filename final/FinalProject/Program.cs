using System;

class Program
{
    static void Main(string[] args)
    {
        List<BudgetItem> budget = new List<BudgetItem> {};
        List<Account> funds = new List<Account> {};
        List<Card> payments = new List<Card> {};
        List<Bill> bills = new List<Bill> {};

        string Menu = @"Please select a menu option.
        0. Quit
        1. Create Budget Item
        2. Display Budget
        3. Edit Account
        4. View Accounts
        5. Record Bill
        6. Make Payment
        7. View Bills
        ";

        int choice = 1000;

        while (choice != 0)
        {
            Console.WriteLine(Menu);
            choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                break;
            }
            else if (choice == 1)
            {

            }
            else if (choice == 2)
            {
                
            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                
            }
            else if (choice == 6)
            {
                
            }
            else if (choice == 7)
            {
                
            }
        }
    }
}