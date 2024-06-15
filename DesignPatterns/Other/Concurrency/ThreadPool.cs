namespace DesignPatterns.CSharp.Other.Concurrency.ThreadPool;

using System.Threading;

// Este patrón gestiona un conjunto de hilos reutilizables para ejecutar tareas.
public class Program
{
    public void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            int taskNo = i;
            ThreadPool.QueueUserWorkItem(state =>
            {
                Console.WriteLine($"Task {taskNo} is running on thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            });
        }

        Console.WriteLine("All tasks queued.");
        Thread.Sleep(5000);
    }
}
