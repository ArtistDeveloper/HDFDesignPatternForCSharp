using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class Hottub
    {
        private bool _on;
        private int _temperature;

        public void On()
        {
            _on = true;
        }

        public void Off()
        {
            _on = false;
        }

        public void BubblesOn()
        {
            if (_on)
            {
                Console.WriteLine("온수 욕조 거품 생성!");
            }
        }

        public void BubblesOff()
        {
            if (_on)
            {
                Console.WriteLine("온수 욕조 거품 생성 종료!");
            }
        }

        public void JetsOn()
        {
            if (_on)
            {
                Console.WriteLine("온수 욕조 Jet 기능 실행");
            }
        }

        public void JetsOff()
        {
            if (_on)
            {
                Console.WriteLine("온수 욕조 Jet 기능 종료");
            }
        }

        public void SetTemparature(int temperature)
        {
            _temperature = temperature;
        }

        public void Heat()
        {
            _temperature = 105;
            Console.WriteLine("온수 욕조가 105도로 데워집니다");
        }

        public void Cool()
        {
            _temperature = 98;
            Console.WriteLine("온수 욕조가 98도까지 차가워집니다");
        }
    }
}
