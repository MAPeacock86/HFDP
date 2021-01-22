using ObserverPattern.Displays;

namespace ObserverPattern
{

    internal interface IWeatherSubject
    {
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

}