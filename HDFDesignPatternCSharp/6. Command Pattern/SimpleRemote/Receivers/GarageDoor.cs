using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("차고문이 열렸습니다");
        }

        public void Down()
        {
            Console.WriteLine("차고문이 닫혔습니다");
        }

        public void Stop()
        {
            Console.WriteLine("차고문이 멈췄습니다");
        }

        public void LightOn()
        {
            Console.WriteLine("차고의 등이 켜졌습니다");
        }

        public void LightOff()
        {
            Console.WriteLine("차고의 등이 꺼졌습니다");
        }
    }
}
