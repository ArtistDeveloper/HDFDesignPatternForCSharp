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

        public float Temperature { get => temperature; set => temperature = value; }
        public float Humidity { get => humidity; set => humidity = value; }
        public float Pressure { get => pressure; set => pressure = value; }

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
                observer.Update();
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
