using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // 인보커 클래스. 클라이언트에서 인보커의 SetCommand 메서드를 통해 커맨드를 지정한다.
    public class SimpleRemoteContorl
    {
        ICommand slot;

        // 슬롯을 가지고 제어할 명령을 설정하는 메서드. 리모컨 버튼의 기능을 바꾸고 싶다면 이 메서드를 언제든지 사용 가능하다.
        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.Execute();
        }
    }
}
