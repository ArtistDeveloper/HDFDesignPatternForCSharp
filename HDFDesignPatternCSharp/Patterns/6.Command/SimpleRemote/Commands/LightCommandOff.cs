using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightCommandOff : ICommand
    {
        private readonly Light _light;

        public LightCommandOff(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
