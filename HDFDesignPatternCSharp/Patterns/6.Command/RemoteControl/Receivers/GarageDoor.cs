using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up() => Console.WriteLine(_location + " 차고문이 열립니다");

        public void Down() => Console.WriteLine(_location + " 차고문이 닫힙니다");

        public void Stop() => Console.WriteLine(_location + " 차고문이 정지합니다");

        public void LightOn() => Console.WriteLine(_location + " 차고등이 켜집니다");

        public void LightOff() => Console.WriteLine(_location + " 차고등이 꺼집니다");
    }
}
