
Njogu Gichiah <njogugichiah@gmail.com>
Tue, Mar 25, 5:12 AM (2 days ago)
to louiegpaul

using System;
class Program
{
    static void Main()
    {
        string [] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled"};
        for (int i = 0; i<orderStatuses.Length; i++)
        {
            string orderStatus = orderStatuses[i];
           
            switch (orderStatus)
            {
                case "Pending":
                Console.WriteLine($"The order is {orderStatus}");
                break;
               
                 case "Shipped":
                Console.WriteLine($"The order is {orderStatus}");
                break;
               
                 case "Delivered":
                Console.WriteLine($"The order is {orderStatus}");
                break;
               
                 case "Cancelled":
                Console.WriteLine($"The order is {orderStatus}");
                break;
               
                 default:
                Console.WriteLine($"The order status is invalid");
                break;
            }
        }
    }
}
