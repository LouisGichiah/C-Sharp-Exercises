using System;
class Program
{
    static void Main()
    {
        double income;
        Console.WriteLine("Enter your income: ");
        income = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Are you a Resident? yes/no");
        string residentInput = Console.ReadLine();
        bool isResident = residentInput.ToLower() == "yes";
        double taxRate=0.0;
        double tax;
        if (income < 50000)
        {
            if(isResident)
            {
                taxRate=0.10;
            }
            else
            {
                taxRate=0.15;
            }
        }
        else if(income >= 50000 && income <= 100000)
        {
            if(isResident)
            {
                taxRate=0.20;
            }
            else
            {
                taxRate=0.25;
            }
        }
         else
        {
            if(isResident)
            {
                taxRate=0.30;
            }
            else
            {
                taxRate=0.35;
            }
        }
        tax = income * taxRate;
        Console.WriteLine("Your expected tax is $:" +tax);
    }
}