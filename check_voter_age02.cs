using System;
class Program
{
    static void Main()
    {
        int voterAge;
        Console.WriteLine("Enter Voter Age: ");
        voterAge=int.Parse(Console.ReadLine());
        if (voterAge >= 18)
        {
            Console.WriteLine("Acess Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}