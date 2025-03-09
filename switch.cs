using System;
class Program
{
    static void Main()
    {
        string button;
        switch (button)
        {
            case "Water":
            Console.WriteLine("Dispensing Water");
            break;
            
            case "Soda":
            Console.WriteLine("Dispensing Soda");
            break;
            
            case "Coffee":
            Console.WriteLine("Dispensing Coffe");
            break;
            
            default:
            Console.WriteLine("Invalid Option");
            break;
        }
    }
}