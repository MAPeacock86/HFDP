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

        public abstract void Display();
    }
}
