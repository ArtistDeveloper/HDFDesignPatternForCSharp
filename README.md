# Head First Design Pattern
Head First Design Pattern의 코드를 C#으로 구현해보는 레포지토리입니다.

HDFDesignPatternCSharp 디렉토리 내부에 책의 Chapter별로 프로젝트를 분리해놓았습니다. 각 프로젝트마다 main함수가 하나씩 있으므로 실행해보고 싶은 프로젝트를 제외한 다른 프로젝트를 언로드한 상태로 main함수를 실행시켜 주세요.

Head First Desing Pattern책은 자바 기반으로 작성되어 있는 책이기에 C#의 컨벤션을 따라 코드를 재작성했습니다.

아래 설명과 이미지는 저가 작성한 것이라, 책과는 조금 다를 수 있습니다.

---

## 1.전략 패턴(strategy pattern)
![image](https://user-images.githubusercontent.com/40491724/171191181-68213905-6427-48c3-8a84-e50a752dff81.png)

위의 이미지 처럼 코드 구조를 짤 수 있으려면, 인터페이스 형식(굳이 interface가 아닌 상위 형식을 말함)에 맞추어 개발하는 것이 중요합니다.

캡슐화
- 달라지는 부분을 찾아서 나머지 코드에 영향을 주지 않도록 ‘캡슐화’ 합니다.
- 이러면 나중에 바뀌지 않는 부분에는 영향을 미치지 않고 그 부분만 고치거나 확장할 수 있습니다.
- 이 방법은 모든 패턴의 기반을 이루는 원칙입니다.


디자인 원칙
- 상속보다는 구성을 활용한다.
- 구현보다는 인터페이스에 맞춰서 프로그래밍한다.


### 전략 패턴
알고리즘군을 정의하고 캡슐화해서 각각의 알고리즘군을 수정해서 쓸 수 있게 해 줍니다. 전략 패턴을 사용하면 클라이언트로부터 알고리즘을 분리해서 독립적으로 분리할 수 있습니다.
