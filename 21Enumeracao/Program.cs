using _21Enumeracao.Entities;
using _21Enumeracao.Entities.Enums;

namespace _21Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            // converter enum em string
            Console.WriteLine(OrderStatus.PendingPayment.ToString());

            // converter string em enum
            Console.WriteLine(Enum.Parse<OrderStatus>("Delivered"));
        }
    }
}