namespace DesignPatterns.CSharp.Other.Architectural.MVC
{
    // Este patrón separa la aplicación en tres componentes principales: Model, View y Controller.

    // Model
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    // View
    public class ProductView
    {
        public void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        }
    }

    // Controller
    public class ProductController
    {
        private Product _product;
        private ProductView _view;

        public ProductController(Product product, ProductView view)
        {
            _product = product;
            _view = view;
        }

        public void UpdateProductName(string name)
        {
            _product.Name = name;
        }

        public void UpdateProductPrice(decimal price)
        {
            _product.Price = price;
        }

        public void DisplayProduct()
        {
            _view.DisplayProductDetails(_product);
        }
    }

    public class Program
    {
        public void Main()
        {
            Product product = new() { Id = 1, Name = "Laptop", Price = 999.99m };
            ProductView view = new();
            ProductController controller = new(product, view);

            controller.DisplayProduct();
            controller.UpdateProductName("Gaming Laptop");
            controller.UpdateProductPrice(1299.99m);
            controller.DisplayProduct();
        }
    }
}