using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the drivers age: ");
        int driverAge = int.Parse(Console.ReadLine());
        bool canDrive = IsOldEnoughToDrive(driverAge);
        if(canDrive)
        {
            Console.WriteLine("The drivers age is valid");
        }
        else
        {
            Console.WriteLine("The drivers age is invalid!!");
        }
    }
    public static bool IsOldEnoughToDrive(int age)
    {
        if(age>=18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}