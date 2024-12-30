using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}
