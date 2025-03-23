using System;
class Program
{
    static void Main()
    {
        int [] studentScores = {45, 60, 72,38,55};
        for(int i=0; i<studentScores.Length; i++)
            if (studentScores[i] < 50)
            {
                Console.WriteLine(studentScores[i]+ " Fail");
            }
            else
            {
                Console.WriteLine(studentScores[i]+ " Pass");
            }
    }
}