using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverPattern_WeatherStation.IObserverPatternInterface;

namespace ObserverPattern_WeatherStation.ObserverPattern_Implement
{
    public class WeatherData : ISubject
    {
        private List<IObserver> IObservers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            IObservers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            IObservers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            IObservers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in IObservers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
