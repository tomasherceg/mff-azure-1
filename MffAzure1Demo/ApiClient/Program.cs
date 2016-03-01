using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Azuremffapi();

            var orders = client.Orders.GetOrders();
            foreach (var order in orders)
            {
                Console.WriteLine(order.Id);
                Console.WriteLine(order.CreatedDate);
                Console.WriteLine(order.Number);
                Console.WriteLine(order.Price);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
