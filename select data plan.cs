using System;
class Program
{
    static void Main()
    {
        int dataRequirement;
        Console.WriteLine("Enter data requirement in GB: ");
        dataRequirement = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you require international calls? yes/no");
        string internationalCallInput = Console.ReadLine();
        bool wantsInternationalCalls = internationalCallInput.ToLower() == "yes";
        string plan;
        
        switch(dataRequirement)
        {
            case 2:
             plan = "Basic Plan";
             Console.WriteLine("You have subscribed to the Basic Plan");
             break;
             
             case 5:
             plan = "Standard Plan";
             Console.WriteLine("You have subscribed to the Standard Plan");
             break;
             
             case 10:
             if (wantsInternationalCalls)
             {
                 plan = "Premium Plan";
                 Console.WriteLine("You are choosing the Premium Plan with International Calling");
             }
             else
             {
                 plan = "Standard Plan";
                 Console.WriteLine("You are choosing the Standard Plan with International Calling");
             }
             break;
             
             case -1:
             plan = "Elite Plan";
             Console.WriteLine("You have subscribed to the Elite Plan");
             break;
             
             default:
             Console.WriteLine("Please select a valid data requirement, 2GB, 5GB, 10GB or -1");
             break;
        }
    }
}