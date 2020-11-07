
using StrategyPattern.Behaviors;
namespace StrategyPattern.Ducks
{
    internal class ReadheadDuck : Duck
    {
        public ReadheadDuck(){
            FlyBehavior = new FlyWithWings();
        }

        public override void Display(){
            System.Console.WriteLine("I'm a red headed duck!");
        }
    }
    
}