//using Microsoft.AspNetCore.Mvc;

//namespace DesignPatterns.CSharp.Other.Architectural
//{
//    // Este patrón arquitectónico descompone una aplicación en servicios pequeños y autónomos que se comunican entre sí.

//    // Ejemplo simplificado de un microservicio con ASP.NET Core
//    // ProductoController.cs
//    [Route("api/[controller]")]
//    public class ProductoController : Controller
//    {
//        [HttpGet("{id}")]
//        public IActionResult GetProducto(int id)
//        {
//            var producto = new Producto { Id = id, Nombre = "Laptop", Precio = 999.99m };
//            return Ok(producto);
//        }
//    }

//    // Producto.cs (Model)
//    public class Producto
//    {
//        public int Id { get; set; }
//        public string Nombre { get; set; }
//        public decimal Precio { get; set; }
//    }

//    // Startup.cs (Configurar servicios y middleware)
//    public class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddMvc();
//        }

//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {
//            app.UseMvc();
//        }
//    }

//    // Program.cs (Punto de entrada)
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateWebHostBuilder(args).Build().Run();
//        }

//        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
//    }

//}
