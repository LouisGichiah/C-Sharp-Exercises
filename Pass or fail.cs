using System;
class Program
{
    static void Main()
    {
        int grade;
        Console.WriteLine("Enter student's grade: ");
        grade = int.Parse(Console.ReadLine());
        if (grade >= 50)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}      