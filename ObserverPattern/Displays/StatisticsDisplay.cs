using System;

namespace ObserverPattern.Displays {

    internal class StatisticsDisplay : IWeatherObserver{

        private float _avgTemp;
        private float _minTemp;
        private float _maxTemp;
        private int _counter;

        internal StatisticsDisplay(IWeatherSubject weatherData){
            weatherData.RegisterObserver(this);
        }

        internal StatisticsDisplay(){
            _minTemp = float.MaxValue;
            _maxTemp = float.MinValue;
            _avgTemp = 0;
            _counter = 0;
        }

        public void Update(float temperature, float humidity, float pressure){
            updateMaxTemp(temperature);
            updateMinTemp(temperature);
            updateAvgTemp(temperature);
            display();
        }

        private void updateMaxTemp(float newTemp){
            if (newTemp > _maxTemp){
                _maxTemp = newTemp;
            }
        }

        private void updateMinTemp(float newTemp){
            if (newTemp < _minTemp){
                _minTemp = newTemp;
            }
        }

        private void updateAvgTemp(float temperature)
        {
            var pastValue = _avgTemp * (float)_counter;
            _counter++;
            _avgTemp = (pastValue + temperature) / _counter;
        }
        private void display(){
            System.Console.WriteLine($"Avg/Max/Min temperatue: {_avgTemp}/{_maxTemp}/{_minTemp}");
        }

    }
}
