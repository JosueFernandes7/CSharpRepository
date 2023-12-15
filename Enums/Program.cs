using Enums.Entities;
using Enums.Entities.Enums;
namespace Enums
{   

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
        }

    }
}