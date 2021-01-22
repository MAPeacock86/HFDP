namespace ObserverPattern.Displays
{
    internal interface IWeatherObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}