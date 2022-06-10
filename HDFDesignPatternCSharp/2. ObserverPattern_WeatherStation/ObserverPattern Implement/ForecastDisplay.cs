using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverPattern_WeatherStation.IObserverPatternInterface;

namespace ObserverPattern_WeatherStation.ObserverPattern_Implement
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.2f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.Pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("기상예보: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("날씨가 좋아지고 있습니다!");
            }
            else if(currentPressure == lastPressure)
            {
                Console.WriteLine("지금과 비슷할 것 같습니다.");
            }
            else if(currentPressure < lastPressure)
            {
                Console.WriteLine("쌀쌀하며 비가 올 것 같습니다.");
            }
        }
    }
}
