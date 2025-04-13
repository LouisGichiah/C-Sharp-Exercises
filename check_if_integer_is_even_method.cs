using System;
class Program
{
   
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int testNumber = int.Parse(Console.ReadLine());
        bool result = IsPositive(testNumber);
            if (result == true)
            {
                Console.WriteLine("The number "+testNumber+ " is even");
            }
            else 
            {
                Console.WriteLine("The number "+testNumber+ " is odd");     
            } 
    }
    static bool IsPositive(int Number)
    {
        if (Number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}