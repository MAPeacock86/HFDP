using ObserverPattern.Displays;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            new CurrentConditionsDisplay(weatherData);
            new ForecastDisplay(weatherData);
            var s = new StatisticsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            System.Console.WriteLine("---------------------------------------");
            weatherData.SetMeasurements(82, 70, 29.2f);
            System.Console.WriteLine("---------------------------------------");
            weatherData.SetMeasurements(78, 90, 29.2f);
            System.Console.WriteLine("---------------------------------------");
            weatherData.RemoveObserver(s);
            weatherData.SetMeasurements(80, 65, 30.4f);
        }
    }
}
