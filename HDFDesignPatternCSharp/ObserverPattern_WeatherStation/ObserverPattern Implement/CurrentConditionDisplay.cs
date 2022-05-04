using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern_WeatherStation.ObserverPatternInterface;

namespace ObserverPattern_WeatherStation.ObserverPattern_Implement
{
    public class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            this.temperature = temprature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("현재 상태: 온도 " + temperature + "F, 습도 " + humidity + "%");
        }
    }
}
