using System;
class Program
{
    static double CalculateTriangleArea (double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base of the rectangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of the rectangle: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = CalculateTriangleArea(baseLength, height);
        Console.WriteLine($"The area of the triangle is {area}");
        
    }
}