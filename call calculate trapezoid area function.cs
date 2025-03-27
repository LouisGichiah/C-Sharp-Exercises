using System;
class Program
{
    static double CalculateTrapezoidArea (double a, double b, double height)
    {
        return (a+ b)/2 * height;
    }
    static void Main(string [] args)
    {
        Console.WriteLine("Enter the topside length of the trapezoid: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the bottom side length of the trapezoid: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = CalculateTrapezoidArea(a,b, height);
        Console.WriteLine($"The area of the trapezoid is {area}");
    }
}
