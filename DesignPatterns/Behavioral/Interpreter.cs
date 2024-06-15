namespace DesignPatterns.CSharp.Behavioral.Interpreter
{
    internal class Interpreter
    {
    }

    public interface IExpression
    {
        int Interpret();
    }

    public class Number : IExpression
    {
        private readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }

    public class Add : IExpression
    {
        private readonly IExpression _leftExpression;
        private readonly IExpression _rightExpression;

        public Add(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }

    public class Subtract : IExpression
    {
        private readonly IExpression _leftExpression;
        private readonly IExpression _rightExpression;

        public Subtract(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() - _rightExpression.Interpret();
        }
    }

    public class Program
    {
        public void Main()
        {
            // Construir la expresión: (5 + 10) - (3 + 2)
            IExpression five = new Number(5);
            IExpression ten = new Number(10);
            IExpression three = new Number(3);
            IExpression two = new Number(2);

            IExpression addition1 = new Add(five, ten); // (5 + 10)
            IExpression addition2 = new Add(three, two); // (3 + 2)

            IExpression finalExpression = new Subtract(addition1, addition2); // (5 + 10) - (3 + 2)

            int result = finalExpression.Interpret();

            Console.WriteLine("Resultado de la expresión: " + result); // Debería imprimir 10
        }
    }
}
