using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute() => _ceilingFan.High();
    }
}
