using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new Ducks.MallardDuck();
            runDuck("Mallard", mallardDuck);

            Duck redheadDuck = new Ducks.MallardDuck();
            runDuck("Redhead", redheadDuck);

            Duck rubberDuck = new Ducks.MallardDuck();
            runDuck("Rubber", rubberDuck);
        }

        private static void runDuck(string name, Duck duck){
            Console.WriteLine($"Simmulating duck -- {name}");
            duck.Display();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            Console.WriteLine("Simmulation Complete\n\n\n");
        }
    }
}
