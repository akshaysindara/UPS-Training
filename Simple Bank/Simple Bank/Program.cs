using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Simple Bank!");
        string AuthName = "akshay";
        string AuthPin = "1234";
        float balance = 1000.00f;
        Console.WriteLine("do you have an account with us? (yes/no)");
        string ans = Console.ReadLine();
        if (ans.ToLower() == "yes")
        {
            Console.WriteLine("Great! Let's proceed with the login process.");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            if (name == AuthName)
            {
                Console.WriteLine($"Hello, {name}! Let's get started with your banking experience.");
                Console.WriteLine("Enter your pin number:");
                string pin = Console.ReadLine();
                if (pin == AuthPin)
                {
                    Console.WriteLine("Login successful! You can now access your account.");
                    Console.WriteLine($"Your Balance is {balance} ");
                    Console.WriteLine("Do you want to deposit or withdraw? (deposit/withdraw)");
                    string opt = Console.ReadLine();
                    if (opt.ToLower() == "deposit")
                    {
                        Console.WriteLine("Enter the amount to deposit:");
                        float depositAmount = float.Parse(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine($"Deposit successful! Your new balance is {balance}");
                    }
                    else if (opt.ToLower() == "withdraw")
                    {
                        Console.WriteLine("Enter the amount to withdraw:");
                        float withdrawAmount = float.Parse(Console.ReadLine());
                        if (withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"Withdrawal successful! Your new balance is {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter 'deposit' or 'withdraw'.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
        }
        else if (ans.ToLower() == "no")
        {
            Console.WriteLine("No worries! Let's create a new account for you.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            return;
        } 
        
    }
}

