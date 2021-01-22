namespace ObserverPattern.Displays {

    internal class CurrentConditionsDisplay : IWeatherObserver{

        private float _temperature;
        private float _humidity;
        private float _pressure;

        internal CurrentConditionsDisplay(IWeatherSubject weatherData){
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure){
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            display();
        }

        private void display(){
            System.Console.WriteLine($"Current conditions: {_temperature}F degress and {_humidity}% hummidity");
        }
    }
}
