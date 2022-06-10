using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverPattern_WeatherStation.IObserverPatternInterface;

namespace ObserverPattern_WeatherStation.ObserverPattern_Implement
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.temperature = weatherData.Temperature;
            this.humidity = weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("현재 상태: 온도 " + temperature + "F, 습도 " + humidity + "%");
        }
    }
}
