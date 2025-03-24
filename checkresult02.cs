using System;
class Program
{
    static void Main()
    {
        int [] grades = {87,45,67,89,92,54,32};
        for (int i=0; i<grades.Length;i++)
        {
        int grade = grades[i];
        string result;
            if (grade <= 65)
            {
                result="Fail";
            }
            else
            {
                result="Pass";
            }
            Console.WriteLine($"{grade} : {result}");
        }
    }
}