using System;
class Public
{
    static void Main()
    {
        string [] weatherForecast = {"sunny and warm", "rainy with thunderstorms", "cloudy and cold"};
        for (int i = 0; i < weatherForecast.Length; i++)
        {
            switch (weatherForecast[i])
            {
                case "sunny and warm":
                Console.WriteLine("Today will be "+weatherForecast[i]+" so bring your sunglasses");
                break;
                
                case "rainy with thunderstorms":
                Console.WriteLine("Today will be "+weatherForecast[i]+" so bring your umbrella");
                break;
                
                case "cloudy and cold":
                Console.WriteLine("Today will be "+weatherForecast[i]+" so wear warm clothes");
                break;
            }
        }
    }
}