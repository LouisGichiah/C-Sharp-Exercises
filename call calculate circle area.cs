using System;
class Program
{
    static double CalculateCircleArea (double radius)
    {
        return Math.PI * radius * radius;
    }
    static void Main(string [] args)
    {
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"The area of the circle is {area}");
    }
}
