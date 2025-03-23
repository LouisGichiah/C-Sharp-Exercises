using System;
class Program
{
    static void Main()
    {
        int number=0;
        Console.WriteLine("Enter a valid integer:");
        number=int.Parse(Console.ReadLine());
        int factorial = 1;
        int factorialOut;
        while(factorial<=5)
        {
            factorialOut= number*factorial;
            Console.WriteLine("the factorial of " +number+ " is " +factorialOut);
            factorial++;
        }
    }
}