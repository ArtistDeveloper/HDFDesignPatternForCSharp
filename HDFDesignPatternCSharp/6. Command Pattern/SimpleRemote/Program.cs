namespace CommandPattern
{
    public class RemoteControlTest
    {
        static void Main(string[] args)
        {
            SimpleRemoteContorl remote = new SimpleRemoteContorl(); // remote 변수가 인보커의 역할을 수행 필요한 작업은 커맨드 객체를 인자로 전달받음
            Light light = new Light(); // 요청을 받아서 처리할 리시버인 Light 객체를 생성
            GarageDoor garageDoor = new GarageDoor();

            LightOnCommand lightOn = new LightOnCommand(light); // 커맨드 객체를 생성할 때 리시버를 전달해준다.
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.buttonWasPressed();
            remote.SetCommand(garageOpen);
            remote.buttonWasPressed();    
        }
    }
}
