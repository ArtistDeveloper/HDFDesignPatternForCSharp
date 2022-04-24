using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern_WeatherStation.ObserverPatternInterface;

namespace ObserverPattern_WeatherStation.ObserverPattern_Implement
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {

        }

        public void RemoveObserver(Observer o)
        {

        }

        public void NotifyObservers()
        {

        }
    }
}
