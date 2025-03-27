using System;
class Program
{
    static double CalculateTrapezoidArea (double topLength, double bottomLength, double height)
    {
        return (topLength + bottomLength)/2 * height;
    }
}