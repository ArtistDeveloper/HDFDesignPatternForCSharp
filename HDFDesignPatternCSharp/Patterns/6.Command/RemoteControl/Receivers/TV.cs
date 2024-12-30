using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class TV
    {
        private string _location;
        private int _channel;

        public TV(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine("채널이 VCR로 설정되었습니다");
        }
    }
}
