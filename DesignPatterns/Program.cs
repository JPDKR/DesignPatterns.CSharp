namespace DesignPatterns.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su tipo de patrón.\n1. Estructural.\n2. Creacional.\n3. Comportamiento");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: MostrarMenuEstructural(); break;
                    case 2: MostrarMenuCreacional(); break;
                    case 3: MostrarMenuComportamiento(); break;
                    case 66: MasPatrones(); break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void MostrarMenuEstructural()
        {
            Console.WriteLine("Eligió Patrones Estructurales.");
            Console.WriteLine("Seleccione su patrón");
            Console.WriteLine("1. Adapter.\n2. Bridge.\n3. Composite.\n4. Decorator.\n5. Facade.\n6. Flyweight.\n7. Proxy");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: new Structural.Adapter.Program().Main(); break;
                    case 2: new Structural.Bridge.Program().Main(); break;
                    case 3: new Structural.Composite.Program().Main(); break;
                    case 4: new Structural.Decorator.Program().Main(); break;
                    case 5: new Structural.Facade.Program().Main(); break;
                    case 6: new Structural.Flyweight.Program().Main(); break;
                    case 7: new Structural.Proxy.Program().Main(); break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void MostrarMenuCreacional()
        {
            Console.WriteLine("Eligió Patrones Creacionales.");
            Console.WriteLine("Seleccione su patrón");
            Console.WriteLine("1. Abstract Factory.\n2. Builder.\n3. Factory Method.\n4. Prototype.\n5. Singleton (Non-Thread Safe).\n6. Singleton (Thread Safe)");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: new Creational.AbstractFactory.Program().Main(); break;
                    case 2: new Creational.Builder.Program().Main(); break;
                    case 3: new Creational.FactoryMethod.Program().Main(); break;
                    case 4: new Creational.Prototype.Program().Main(); break;
                    case 5: new Creational.Singleton.NonThreadSafe.Program().Main(); break;
                    case 6: new Creational.Singleton.ThreadSafe.Program().Main(); break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void MostrarMenuComportamiento()
        {
            Console.WriteLine("Eligió Patrones de Comportamiento.");
            Console.WriteLine("Seleccione su patrón");
            Console.WriteLine("1. Chain Of Responsibility.\n2. Command.\n3. Interpreter.\n4. Iterator.\n5. Mediator.\n6. Memento.\n7. Observer.\n8. State.\n9. Strategy.\n10. Template Method.\n11. Visitor.");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: new Behavioral.ChainOfResponsibility.Program().Main(); break;
                    case 2: new Behavioral.Command.Program().Main(); break;
                    case 3: new Behavioral.Interpreter.Program().Main(); break;
                    case 4: new Behavioral.Iterator.Program().Main(); break;
                    case 5: new Behavioral.Mediator.Program().Main(); break;
                    case 6: new Behavioral.Memento.Program().Main(); break;
                    case 7: new Behavioral.Observer.Program().Main(); break;
                    case 8: new Behavioral.State.Program().Main(); break;
                    case 9: new Behavioral.Strategy.Program().Main(); break;
                    case 10: new Behavioral.TemplateMethod.Program().Main(); break;
                    case 11: new Behavioral.Visitor.Program().Main(); break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void MasPatrones()
        {
            Console.WriteLine("Patrones de Concurrencia:" +
                "\r\n\r\n" +
                "1. Producer-Consumer\r\n" +
                "2. Read-Write Lock\r\n" +
                "3. Thread Pool\r\n\r\n" +
                "Patrones Arquitectónicos:\r\n\r\n" +
                "4. MVC (Model-View-Controller)\r\n" +
                "5. MVVM (Model-View-ViewModel)\r\n" +
                "6. Microservicios\r\n" +
                "7. Service-Oriented Architecture (SOA)\r\n\r\n" +
                "Patrones Específicos de Dominios:\r\n\r\n" +
                "8. Repository\r\n" +
                "9. Unit of Work\r\n" +
                "10. Domain Model");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();

                switch (opcion)
                {
                    case 1: new Other.Concurrency.ProducerConsumer.Program().Main(); break;
                    case 2: new Other.Concurrency.ReadWriteLock.Program().Main(); break;
                    case 3: new Other.Concurrency.ThreadPool.Program().Main(); break;
                    case 4: new Other.Architectural.MVC.Program().Main(); break;
                    case 5: // MVVM - Solo en WPF.
                    case 6: // Microservicios - Solo con AspNet
                    case 7: new Other.Architectural.ServiceOrientedArchitecture.Program().Main(); break;
                    case 8: new Other.Domain.Repository.Program().Main(); break;
                    case 9: new Other.Domain.UnitOfWork.Program().Main(); break;
                    case 10: // Domain Model - Es solo muestra.
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}