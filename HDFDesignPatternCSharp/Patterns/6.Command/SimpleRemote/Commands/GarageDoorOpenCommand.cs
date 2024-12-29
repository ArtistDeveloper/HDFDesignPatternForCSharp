using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
