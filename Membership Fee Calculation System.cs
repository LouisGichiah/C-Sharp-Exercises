using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Are you a Premium Member? yes/no ");
        string memberType = Console.ReadLine();
        bool isPremiumMember = memberType.ToLower() == "yes";
        double fee=0.0;

        if (age < 18 )
        {
            if (isPremiumMember)
            {
                fee = 15;
            }
            else
            {
                fee = 25;
            }
        }
        else if ( age >= 18 && age <= 60)
        {
            if (isPremiumMember)
            {
                fee = 30;
            }
            else
            {
                fee = 50;
            }
        }
        else if (age > 60)
         {
            if (isPremiumMember)
            {
                fee = 20;
            }
            else
            {
                fee = 35;
            }
        }
        else
        {
            Console.WriteLine("Enter a valid age");
        }
        Console.WriteLine("Your membership fee is $ " +fee);
    }
}