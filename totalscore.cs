using System;
class Program
{
    static void Main()
    {
        int [] scores = {85, 90, 78, 92, 88};
        int totalScore=0;
        for (int i =0; i<scores.Length; i++)
        {
            totalScore += scores[i];
        }
        Console.WriteLine("Your Total score is " +totalScore);
    }
}