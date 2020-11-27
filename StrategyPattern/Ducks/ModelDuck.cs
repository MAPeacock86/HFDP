using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck(){
            FlyBehavior = new FlyNoWay();
        }

        public override void Display(){
            System.Console.WriteLine("I'm a model duck!");
        }
    }
    
}