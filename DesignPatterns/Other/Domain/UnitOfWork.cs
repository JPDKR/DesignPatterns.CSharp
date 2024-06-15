using System.Data.SqlClient;

namespace DesignPatterns.CSharp.Other.Domain.UnitOfWork
{
    // Se utiliza para agrupar transacciones y asegurar la consistencia en operaciones relacionadas con la persistencia de datos.

    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
    }

    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SqlConnection _connection;
        private readonly SqlTransaction _transaction;

        public Repository(SqlConnection connection, SqlTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public void Add(T entity)
        {
            // Implementar lógica para agregar la entidad a la base de datos usando ADO.NET
        }

        public void Update(T entity)
        {
            // Implementar lógica para actualizar la entidad en la base de datos usando ADO.NET
        }

        public void Delete(int id)
        {
            // Implementar lógica para eliminar la entidad de la base de datos usando ADO.NET
        }

        public T GetById(int id)
        {
            // Implementar lógica para obtener una entidad por ID de la base de datos usando ADO.NET
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            // Implementar lógica para obtener todas las entidades de la base de datos usando ADO.NET
            return null;
        }
    }

    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> Customers { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlConnection _connection;
        private SqlTransaction _transaction;
        private IRepository<Customer>? _customerRepository;
        private IRepository<Order>? _orderRepository;

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IRepository<Customer> Customers
        {
            get
            {
                _customerRepository ??= new Repository<Customer>(_connection, _transaction);
                return _customerRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                _orderRepository ??= new Repository<Order>(_connection, _transaction);
                return _orderRepository;
            }
        }

        public void Save()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            _customerRepository = null;
            _orderRepository = null;
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection?.Dispose();
        }
    }

    public class Program
    {
        public void Main()
        {
            string connectionString = "your_connection_string_here";

            using var unitOfWork = new UnitOfWork(connectionString);

            var newCustomer = new Customer { Name = "John Doe", Email = "john@example.com" };
            unitOfWork.Customers.Add(newCustomer);

            var newOrder = new Order { OrderDate = DateTime.Now, CustomerId = newCustomer.Id };
            unitOfWork.Orders.Add(newOrder);

            unitOfWork.Save();
        }
    }
}