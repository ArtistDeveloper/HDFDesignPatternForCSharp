using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class CeilingFan
    {
        private readonly string _location;
        private int _level;

        public const int HIGH = 2;
        public const int MEDIUM = 1;
        public const int LOW = 0;

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void High()
        {
            _level = HIGH;
            Console.WriteLine(_location + " 천장 선풍기 강도 높음으로 설정");
        }

        public void Medium()
        {
            _level = MEDIUM;
            Console.WriteLine(_location + " 천장 선풍기 강도 중간으로 설정");
        }

        public void Low()
        {
            _level = LOW;
            Console.WriteLine(_location + " 천장 선풍기 강도 낮음으로 설정");
        }

        public void Off()
        {
            _level = 0;
            Console.WriteLine(_location + " 천장 선풍기 종료");
        }

        public int GetSpeed() => _level;
    }
}
