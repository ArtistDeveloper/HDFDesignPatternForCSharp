using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverPattern_WeatherStation.IObserverPatternInterface;

namespace IObserverPattern_WeatherStation.IObserverPattern_Implement
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

        public void RegisterIObserver(IObserver o)
        {
            IObservers.Add(o);
        }

        public void RemoveIObserver(IObserver o)
        {
            IObservers.Remove(o);
        }

        public void NotifyIObservers()
        {
            foreach (IObserver IObserver in IObservers)
            {
                IObserver.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyIObservers();
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
