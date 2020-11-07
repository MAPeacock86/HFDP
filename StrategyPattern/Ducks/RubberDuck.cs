using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck(){
            FlyBehavior = new FlyNoWay();
        }
        
        public override void Display(){
            System.Console.WriteLine("I'm a rubber duck!");
        }
        
    }
    
}