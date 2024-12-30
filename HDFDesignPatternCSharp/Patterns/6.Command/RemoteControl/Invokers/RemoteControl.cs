using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControl.Commands;

namespace RemoteControl.Invokers
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ 리모컨 ------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "]" + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
