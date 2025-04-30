using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input your integer here: ");
        int integer = int.Parse(Console.ReadLine());
        bool checkInteger = IsPositive(integer);
        Console.WriteLine(checkInteger);
    }
    public static bool IsPositive(int number)
    {
        if (number>=0)
        {
           return true;
        }
        else
        {
            return false;
        }
        
    }
}