using System;
class Program
{
    static void Main()
    {
        double accountBalance;
        Console.WriteLine("Enter your account balance: ");
        accountBalance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your account type: ");
        string account = Console.ReadLine();
        string accountType = account.ToLower();
        int monthlyFee=0;
        double interestRate=0.0;
        double availableBalance;
        
        
        switch(accountType)
        {
            case "savings":
            interestRate = 0.02;
            break;
            
            case "checking":
            monthlyFee = 10;
            break;
            
            case "business":
            interestRate = 0.01;
            monthlyFee = 20;
            break;
            
            default:
            Console.WriteLine("Enter a valid account type; Savings, Checking or Business");
            break;
        }
        availableBalance = accountBalance + (accountBalance * interestRate) - monthlyFee;
        Console.WriteLine("Your available balance is $" +availableBalance);
    }
}