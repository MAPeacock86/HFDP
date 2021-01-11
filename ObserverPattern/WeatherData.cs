namespace ObserverPattern{

    internal class WeatherData{

        private float _temperature;
        private float _humidity;
        private float _pressure;

        private Displays.CurrentConditionsDisplay _currentConditionsDisplay;
        private Displays.ForecastDisplay _forecastDispaly;
        private Displays.StatisticsDisplay _statisticsDisplay;

        internal WeatherData(){
            _currentConditionsDisplay = new Displays.CurrentConditionsDisplay();
            _forecastDispaly = new Displays.ForecastDisplay();
            _statisticsDisplay = new Displays.StatisticsDisplay();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure){
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        internal void MeasurementsChanged(){
            var temp = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();
            _currentConditionsDisplay.Update(temp, humidity, pressure);
            _statisticsDisplay.Update(temp, humidity, pressure);
            _forecastDispaly.Update(temp, humidity, pressure);

        }

        internal float GetTemperature(){
            return _temperature;
        }

        internal float GetHumidity(){
            return _humidity;
        }

        internal float GetPressure(){
            return _pressure;
        }

    }
}