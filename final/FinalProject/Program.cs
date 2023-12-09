using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        List<BudgetItem> budget = new List<BudgetItem> {};
        List<Account> funds = new List<Account> {};
        List<Card> payments = new List<Card> {};
        List<Bill> bills = new List<Bill> {};

        string Menu = @"
        Please select a menu option.
        0. Quit
        1. Create Budget Item
        2. Display Budget
        3. New Bank Account
        4. Edit Account
        5. View Accounts
        6. Record Bill
        7. Make Payment
        8. View Bills
        9. Register New Card
        10. List Cards
        11. Recurring Bill Charge
        ";

        int choice = 1000;

        void DisplayBudget()
        {
            int number = 0;
            foreach (BudgetItem b in budget)
            {
                string line = b.Display();
                number += 1;
                Console.WriteLine($"{number}. {line}");
            }
        }
        
        void DisplayAccounts()
        {
            int number = 0;
            foreach (Account a in funds)
            {
                string line = a.Display();
                number += 1;
                Console.WriteLine($"{number}. {line}");
            }
        }

        void DisplayBills()
        {
            int number = 0;
            foreach (Bill b in bills)
            {
                string line = b.Display();
                number += 1;
                Console.WriteLine($"{number}. {line}");
            }
        }

        void DisplayCards()
        {
            int number = 0;
            foreach (Card c in payments)
            {
                string line = c.Display();
                number += 1;
                Console.WriteLine($"{number}. {line}");
            }
        }

        /*Quit*/
        while (choice != 0)
        {
            Console.WriteLine(Menu);
            Console.Write("Please select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            if (choice == 0)
            {
                Console.WriteLine("Goodbye");
            }

            /*Create a new Budget item */
            else if (choice == 1)
            {
                Console.Write("\nPlease describe the budget item category: ");
                string category = Console.ReadLine();
                Console.Write("\nWhat is the budget amount? ");
                double amount = Double.Parse(Console.ReadLine());

                BudgetItem bNew = new BudgetItem(category, amount);
                budget.Add(bNew);
            }

            /*Display budget */
            else if (choice == 2)
            {
                Console.WriteLine("Your Budget is: ");
                DisplayBudget();
            }

            /*New Bank Account */
            else if (choice == 3)
            {
                Console.Write("\n1. Checkings or 2. Savings account? ");
                int accountChoice = int.Parse(Console.ReadLine());
                Console.Write("\nName the account: ");
                string name = Console.ReadLine();
                Console.Write("\nHow much money is in the account? ");
                double amount = double.Parse(Console.ReadLine());

                if (accountChoice == 1)
                {
                    CheckingsAccount cNew = new CheckingsAccount(name, amount);
                    funds.Add(cNew);
                }

                else if (accountChoice == 2)
                {
                    SavingsAccount sNew = new SavingsAccount(name, amount);
                    funds.Add(sNew);
                }
            }

            /*Edit Account */
            else if (choice == 4)
            {
                Console.WriteLine("Which Account would you like to Edit? ");
                DisplayAccounts();
                int i = int.Parse(Console.ReadLine());
                Console.Write("\n1. Withdraw or 2. Deposit? ");
                int x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    Console.Write("\nHow much would you like to withdraw? ");
                    double w = double.Parse(Console.ReadLine());
                    funds[i-1].Withdraw(w);
                }

                else if (x == 2)
                {
                    Console.Write("\nHow much would you like to deposit? ");
                    double d = double.Parse(Console.ReadLine());
                    funds[i-1].SetMoney(d);
                }
                
            }

            /*View Accounts */
            else if (choice == 5)
            {
                Console.WriteLine("Your Accounts are: ");
                DisplayAccounts();
            }

            /*Create a new Bill */
            else if (choice == 6)
            {
                Console.Write("\n1. One time or 2. Recurring? ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("\nWrite a description or name of the bill: ");
                string description = Console.ReadLine();
                Console.Write("\nHow much is due? ");
                double due = double.Parse(Console.ReadLine());

                if (b == 1)
                {
                    OneTime oNew = new OneTime(description, due);
                    bills.Add(oNew);
                }

                else if (b == 2)
                {
                    Recurring rNew = new Recurring(description, due);
                    bills.Add(rNew);
                }
            }

            /*Make a payment */
            else if (choice == 7)
            {

                Console.WriteLine("Which bill would you like to pay towards? ");
                DisplayBills();

                int b = int.Parse(Console.ReadLine());

                Console.Write("\nHow much would you like to pay? ");
                double paid = double.Parse(Console.ReadLine());
                bills[b-1].MakePayment(paid);

                Console.Write("\nDid you use a card? (y/n) ");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.WriteLine("\nWhich card did you use? ");
                    DisplayCards();
                    int c = int.Parse(Console.ReadLine());
                

                    if (payments[c-1].GetType() == "Debit")
                    {
                        Console.WriteLine("Which account is this linked to? ");
                        DisplayAccounts();
                        int a = int.Parse(Console.ReadLine());
                        payments[c-1].ChargeCard(paid, funds[a-1]);
                    }
                    else
                    {
                        payments[c-1].ChargeCard(paid, null);
                    }
                }

                Console.WriteLine("Which budget is the payment under?");
                DisplayBudget();

                int i = int.Parse(Console.ReadLine());

                budget[i-1].SetUsed(paid);
                Console.WriteLine(budget[i-1].Display());

            }

            /*View Bills */
            else if (choice == 8)
            {
                Console.WriteLine("Your Bills are: ");
                DisplayBills();
            }
            
            /*New Card */
            else if (choice == 9)
            {
                Console.Write("\n1. Debit or 2. Credit? ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("\nWhat are the last four digits of the card number? ");
                string number = Console.ReadLine();
                Console.Write("\nWhat is the card expiry date? (mm/yy) ");
                string expiry = Console.ReadLine();

                if (c == 1)
                {
                    DebitCard dNew = new DebitCard(number, expiry);
                    payments.Add(dNew);
                }

                if (c == 2)
                {
                    Console.Write("\nWhat is the minimum payment? ");
                    double min = double.Parse(Console.ReadLine());
                    CreditCard cNew = new CreditCard(number, expiry, min);
                    payments.Add(cNew);
                }
            }

            /*Display Cards */
            else if (choice == 10)
            {
                Console.WriteLine("Your Cards are: ");
                DisplayCards();
            }

            /*Charge a recurring bill */
            else if (choice == 11)
            {
                Console.WriteLine("Which bill is being charged? ");
                DisplayBills();
                int i = int.Parse(Console.ReadLine());

                string type = bills[i-1].GetType();
                if (type == "Rec")
                {
                    bills[i-1].Charge();
                }
                else
                {
                    Console.WriteLine("That is not a recurring bill");
                }

            }
        }
    }
}