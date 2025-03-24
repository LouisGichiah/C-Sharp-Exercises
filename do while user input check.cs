using System;
class Program
{
    static void Main()
    {
        do
        {
            int userInput;
            Console.WriteLine("Enter an integer between 1 and 10: ");
            userInput = int.Parse(Console.ReadLine());
                if (userInput >= 1 && userInput <= 10 && userInput %2 == 0)
                {
                    Console.WriteLine($"The input {userInput} is valid");
                    break;
                }
                else
                {
                    Console.WriteLine($"The input {userInput} is not valid");
                }
        }
         while(true);
    }
}