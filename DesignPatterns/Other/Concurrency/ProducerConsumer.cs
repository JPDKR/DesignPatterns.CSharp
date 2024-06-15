using System.Collections.Concurrent;

namespace DesignPatterns.CSharp.Other.Concurrency.ProducerConsumer
{
    // Este patrón coordina la producción de tareas y su consumo por uno o más consumidores.
    public class ProducerConsumer
    {
        private readonly BlockingCollection<int> _buffer = new(10);

        public void Start()
        {
            var producer = Task.Run(() => Produce());
            var consumer = Task.Run(() => Consume());

            Task.WaitAll(producer, consumer);
        }

        private void Produce()
        {
            for (int i = 0; i < 20; i++)
            {
                _buffer.Add(i);
                Console.WriteLine($"Produced {i}");
                Thread.Sleep(100);
            }
            _buffer.CompleteAdding();
        }

        private void Consume()
        {
            foreach (var item in _buffer.GetConsumingEnumerable())
            {
                Console.WriteLine($"Consumed {item}");
                Thread.Sleep(150);
            }
        }
    }

    public class Program
    {
        public void Main()
        {
            new ProducerConsumer().Start();
        }
    }
}