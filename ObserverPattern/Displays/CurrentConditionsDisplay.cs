namespace ObserverPattern.Displays {

    internal class CurrentConditionsDisplay{

        private float _temperature;
        private float _humidity;
        private float _pressure;

        internal void Update(float temperature, float humidity, float pressure){
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            display();
        }

        private void display(){
            System.Console.WriteLine($"Current conditions: {_temperature}F degress and {_humidity}% hummidity");
        }

    }
}
