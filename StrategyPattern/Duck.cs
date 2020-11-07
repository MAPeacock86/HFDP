namespace StrategyPattern 
{
    
    internal abstract class Duck
    {
        public void Quack(){
            System.Console.WriteLine("All Ducks Go Quack!");
        }

        public void Swim(){
            System.Console.WriteLine("Swim, swim swim!");
        }

        public void Fly(){
            System.Console.WriteLine("I'm flying!!");
        }

        public abstract void Display();
    }
}
