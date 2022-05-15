using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObserverPattern_WeatherStation.IObserverPatternInterface
{
    public interface ISubject
    {
        void RegisterIObserver(IObserver o);
        void RemoveIObserver(IObserver o);
        void NotifyIObservers();
    }
}
