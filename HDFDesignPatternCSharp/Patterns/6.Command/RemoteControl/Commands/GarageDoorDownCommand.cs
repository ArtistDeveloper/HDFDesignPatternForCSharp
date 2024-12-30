using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute() => _garageDoor.Down();
    }
}
