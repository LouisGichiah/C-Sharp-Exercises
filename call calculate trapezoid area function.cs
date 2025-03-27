using System;
class Program
{
    static double CalculateTrapezoidArea (double topLength, double bottomLength, double height)
    {
        return (topLength + bottomLength)/2 * height;
    }
    static void Main(string [] args)
    {
        Console.WriteLine("Enter the topLength of the trapezoid: ");
        double topLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the bottomLength of the trapezoid: ");
        double bottomLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = CalculateTrapezoidArea(topLength,bottomLength, height);
        Console.WriteLine($"The area of the trapezoid is {area}");
    }
}
