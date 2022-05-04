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

        public void Update(float temp, float humidity, float pressure)
        {

        }

        public void Display()
        {

        }
    }
}
