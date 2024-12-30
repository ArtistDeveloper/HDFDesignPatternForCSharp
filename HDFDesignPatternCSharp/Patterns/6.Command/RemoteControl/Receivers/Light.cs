using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On() => Console.WriteLine(_location + " 조명이 켜졌습니다");

        public void Off() => Console.WriteLine(_location + " 조명이 꺼졌습니다");
    }
}
