using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new ConcreteComponent();

            DecoratorA decoratorA = new DecoratorA(test);
            DecoratorB decoratorB = new DecoratorB(decoratorA);

            Component com = decoratorB;
            Console.WriteLine(com.Operation());
        }
    }
}
