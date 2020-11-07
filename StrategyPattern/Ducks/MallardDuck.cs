using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck(){
            FlyBehavior = new FlyWithWings();
        }

        public override void Display(){
            System.Console.WriteLine("I'm a mallard duck!");
        }
    }
    
}