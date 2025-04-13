using System;
class Program
{
    public static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        static void Main()
        {
            
            Console.WriteLine("Enter your age: ");
            int driverAge =int.Parse(Console.ReadLine());
            bool canDrive =IsOldEnoughToDrive(driverAge);
            if (canDrive)
            {
                Console.WriteLine("The Person is Old enough to Drive");
            }
            else
            {
                Console.WriteLine("The Person is NOT OLD ENOUGH to Drive");
            }
        }
    }