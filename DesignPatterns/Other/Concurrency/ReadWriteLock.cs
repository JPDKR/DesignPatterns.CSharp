namespace DesignPatterns.CSharp.Other.Concurrency.ReadWriteLock
{
    // Este patrón permite múltiples lectores o un único escritor.
    class ReadWriteLockExample
    {
        private readonly ReaderWriterLockSlim _lock = new();
        private readonly List<int> _items = new();

        public void AddItem(int item)
        {
            _lock.EnterWriteLock();
            try
            {
                _items.Add(item);
                Console.WriteLine($"Item {item} added.");
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public void ReadItems()
        {
            _lock.EnterReadLock();
            try
            {
                foreach (var item in _items)
                {
                    Console.WriteLine($"Read item: {item}");
                }
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
    }

    public class Program
    {
        public void Main()
        {
            var example = new ReadWriteLockExample();

            Task.Run(() => example.AddItem(1));
            Task.Run(() => example.ReadItems());

            Thread.Sleep(1000);
        }
    }
}