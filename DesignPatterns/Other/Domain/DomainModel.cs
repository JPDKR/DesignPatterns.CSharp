namespace DesignPatterns.CSharp.Other.Domain.DomainModel
{
    // Se centra en la representación de objetos del dominio y su lógica de negocio.

    // Clases del Domain Model
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int? StockQuantity { get; set; }
        // Otros atributos y métodos relacionados con Product
    }

    public class Order
    {
        public int? Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        // Otros atributos y métodos relacionados con Order

        public decimal CalculateTotal()
        {
            return OrderItems!.Sum(item => item.Quantity * item.Product!.Price);
        }
    }

    public class OrderItem
    {
        public int? Id { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        // Otros atributos y métodos relacionados con OrderItem
    }
}
