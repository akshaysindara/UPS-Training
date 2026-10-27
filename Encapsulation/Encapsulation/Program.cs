using System;
class Bank
{
    private double balance = 0.0;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
            }
        }
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Bank myBank = new Bank();
        myBank.Deposit(1000);
        myBank.Withdraw(500);
        myBank.DisplayBalance();
        myBank.Withdraw(600); // Invalid withdrawal
        myBank.Deposit(-200); // Invalid deposit
        myBank.Balance = 100;
        myBank.DisplayBalance(); // Invalid balance set
    }
}