using System.Collections.Generic;
using ObserverPattern.Displays;

namespace ObserverPattern{

    internal class WeatherData : IWeatherSubject {

        private float _temperature;
        private float _humidity;
        private float _pressure;

        private List<IWeatherObserver> _observers;

        internal WeatherData(){
            _observers = new List<IWeatherObserver>();
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
            NotifyObservers();
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

        public void RegisterObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _observers.Remove(observer); 
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers){
                o.Update(_temperature, _humidity, _pressure);
            }
        }
    }
}