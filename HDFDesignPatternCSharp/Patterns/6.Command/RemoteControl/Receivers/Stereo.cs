using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Receivers
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine(_location + "스테레오가 켜졌습니다");
        }

        public void Off()
        {
            Console.WriteLine(_location + "스테레오가 꺼졌습니다");
        }
        
        public void SetCD()
        {
            Console.WriteLine(_location + "스테레오에 CD가 입력으로 설정되었습니다");
        }

        public void SetDVD()
        {
            Console.WriteLine(_location + "스테레오에 DVD가 입력으로 설정되었습니다");
        }

        public void SetRadio()
        {
            Console.WriteLine(_location + "스테레오에 라디오가 입력으로 설정되었습니다");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine(_location + " 스테레오의 볼륨이 " + volume + "으로 설정되었습니다");
        }
    }
}
