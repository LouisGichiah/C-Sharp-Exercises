using System;
class Program
{
    static void Main()
    {
        int score;
        Console.WriteLine("Enter Students Score: ");
        score=int.Parse(Console.ReadLine());
        switch (score/10)
        {
            case 10:
            Console.WriteLine("A");
            break;
            
            case 9:
            Console.WriteLine("A");
            break;
            
            case 8:
            Console.WriteLine("B");
            break;
            
            case 7:
            Console.WriteLine("C");
            break;
            
            case 6:
            Console.WriteLine("D");
            break;
            
            default:
            Console.WriteLine("F");
            break;
        }
    }
}