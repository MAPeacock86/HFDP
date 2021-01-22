# Strategy Pattern
The _*Observer Pattern*_ defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically

## Design Principles 
- String for loosely coupled designs between objects that interact. 
- Program to an interface, not an implementation
- Favor composition over inheritance 

---

## Example: Weather Station 
The example used in the book is a weather station that has several different display elements that need to be updated. There are three different displays CurrentConditions, ForecastDisplay, and StatisticsDisplay. Each display should be updated whenever the WeatherData object is updated. 

The initial code can be found here: https://github.com/N3rdyM1k3/HFDP/tree/observer-pattern-init

## The Problem
The initial code has tightly coupled the weather data object with the displays. If you make a change to the display classes or if you want to add any additional displays you will have to make a change to the WeatherData object. 

## The Pattern
The observer pattern losely couples the subject and the observers using two interfaces (ISubject and IObserver). The ISubject allows IObservers to register to be informed about a change in state. In the weather station example, the WeatherData object is the subject and the Displays are the observers. 

The updated code can be found here: https://github.com/N3rdyM1k3/HFDP/tree/observer-pattern-part-one/

The book then walks throught the native implementation of the observer pattern in Java. I will do the equivalent for c#. More information can be found here: 
https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern