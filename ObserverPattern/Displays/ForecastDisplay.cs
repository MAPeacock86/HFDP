using System;
using System.Collections.Generic;

namespace ObserverPattern.Displays {

    internal class ForecastDisplay{

        private string _forecast;


        internal void Update(float temperature, float humidity, float pressure){
            // TODO: Replace random logic with predictive model :D 
            var forecasts = new List<string>(){
                "Improving weather on the way", 
                "Watch out for cooler, rainy weather",
                "More of the same" };
            var forecastIndex = new Random((int)DateTime.Now.Ticks).Next(3);
            _forecast = forecasts[forecastIndex];
        }

        internal void Display(){
            System.Console.WriteLine($"Forecast: {_forecast}");
        }

    }
}
