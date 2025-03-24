using System;
class Program
{
    static void Main()
    {
        int number=0;
        Console.WriteLine("Enter a valid integer:");
        number=int.Parse(Console.ReadLine());
		int factorial = 1;
		while (number > 0)
		{
			factorial *= number;
			number--;
		}

		Console.WriteLine("Factorial: " + factorial);
	}
}
