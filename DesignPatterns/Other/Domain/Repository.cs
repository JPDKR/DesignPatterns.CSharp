namespace DesignPatterns.CSharp.Other.Domain.Repository
{
    // Este patrón proporciona una abstracción sobre la lógica de acceso a datos.

    // Model
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    // Interface Repository
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
    }

    // Implementation Repository
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }

    public class Program
    {
        public void Main()
        {
            IProductRepository repository = new ProductRepository();

            var product = new Product { Id = 1, Name = "Laptop", Price = 999.99m };
            repository.Add(product);

            var retrievedProduct = repository.Get(1);
            Console.WriteLine($"Retrieved product: {retrievedProduct.Name}, Price: {retrievedProduct.Price}");
        }
    }

}
