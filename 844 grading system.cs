using System;
class Program
{
    static void Main()
    {
        int [] studentScores = {87,96,54,78,32,65,82};
        for(int i = 0; i<studentScores.Length; i++)
        {
            int score = studentScores[i];
           
            switch(score)
            {
                case int n when (n >= 90):
                Console.WriteLine($"{score} : A");
                break;
               
                case int n when (n >= 80):
                Console.WriteLine($"{score} : B");
                break;
               
                case int n  when (n >= 70):
                Console.WriteLine($"{score} : C");
                break;
               
                case int n  when (n >= 60):
                Console.WriteLine($"{score} : D");
                break;
               
                case int n when (n >= 50):
                Console.WriteLine($"{score} : E");
                break;
               
                default:
                Console.WriteLine($"{score} : F");
                break;
            }
        }
    }
}
