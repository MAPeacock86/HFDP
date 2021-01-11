using StrategyPattern.Behaviors;

namespace StrategyPattern 
{
    
    internal abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;

        public void Quack(){
            System.Console.WriteLine("All Ducks Go Quack!");
        }

        public void Swim(){
            System.Console.WriteLine("Swim, swim swim!");
        }

        public void Fly(){
            FlyBehavior.Fly();
        }
      
        public void SetFlyBehavior(IFlyBehavior flyBehavior){
            FlyBehavior = flyBehavior;
        }
      
        public abstract void Display();
    }
}
