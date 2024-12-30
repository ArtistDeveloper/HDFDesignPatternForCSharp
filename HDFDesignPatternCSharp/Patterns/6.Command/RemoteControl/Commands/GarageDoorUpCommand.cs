using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute() => _garageDoor.Up();
    }
}
