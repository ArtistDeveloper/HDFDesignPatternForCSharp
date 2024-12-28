using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        // 생성자에 이 커맨드 객체로 제어할 특정 조명을 알려주어야 한다.
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
