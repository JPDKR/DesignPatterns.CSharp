namespace DesignPatterns.CSharp.Other.Architectural.ServiceOrientedArchitecture
{
    // Este patrón utiliza servicios para ofrecer funcionalidades específicas y modularizadas.
    // Servicio de ejemplo en SOA

    public interface IOrderService
    {
        void PlaceOrder(Order order);
    }

    public class OrderService : IOrderService
    {
        public void PlaceOrder(Order order)
        {
            Console.WriteLine("Order placed: " + order.ProductName);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public class Program
    {
        public void Main()
        {
            IOrderService orderService = new OrderService();
            orderService.PlaceOrder(new Order { Id = 1, ProductName = "Laptop", Quantity = 1 });
        }
    }

}
