using System;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your third integer: ");
        int num3 = int.Parse(Console.ReadLine());
       
        double average = CalculateAverage(num1,num2,num3);
        Console.WriteLine("The average is: " +average);
    }
    public static int CalculateAverage(int num1,int num2,int num3)
    {
        int average = (num1+num2+num3)/3;
        return average;
    }
}