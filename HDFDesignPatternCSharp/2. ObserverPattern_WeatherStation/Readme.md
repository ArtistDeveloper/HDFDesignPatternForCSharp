## 목차

# 옵저버 패턴(Observer pattern)

## 1. 기상 모니터링 애플레케이션 알아보기

Weather-O-Rama회사의 기상 스테이션 구축 프로젝트 제작을 협업하게 되었습니다.

Weather-O-Rama에서 제공하는 부분을 살펴봅시다. 여기서 우리가 만들거나 확장해야 하는 부분을 전부 파악해야 합니다.

<p align="center">
    <img src = "https://user-images.githubusercontent.com/40491724/184124857-5e3b4d1f-23ae-4c47-99c6-06f8457b519b.png"/ height="70%" width="70%">
</p>

- 기상 스테이션(실제 기상 정보를 수집하는 물리 장비)
- WeatherData 객체(기상 스테이션으로부터 오는 정보를 추적하는 객체)
- 사용자에게 현재 기상조건을 보여 주는 디스플레이 장비

**목표**
Weather-O-Rama와 계약을 체결하면 WeatherData 객체로 현재 조건, 기상 통계, 기상 예보 이렇게 3가지 항목을 디스플레이 장비에서 갱신해 가면서 보여주는 애플리케이션을 만드는 것이 목표입니다.


### 1.1 WeatherData 클래스 살펴보기

<p align="center">
  <img src="https://user-images.githubusercontent.com/40491724/184126542-b36a9258-d5f4-4a87-b5e6-253c8b44eff2.png"/>
</p>

우선 기상 스테이션에서 갱신된 정보를 가져오는 일은 WeatherData 객체가 알아서 해 준다는 점만 알고 있으면 됩니다.

우리가 주목해야 할 점은 'MeasurementsChanged()' 메소드 입니다.

```CSharp
measurementsChanged()
// 기상 관측값이 갱신될 때마다 이 메소드가 호출됩니다.
public void MeasurementsChanged()
{
    // 코드가 들어갈 자리
}

```

Weather-O-Rama에서 "// 코드가 들어갈 자리"에 우리 코드를 여기에 넣으면 된다고 주석을 남겨둔 것 같습니다. 여기에 **디스플레이를 업데이트하는 코드**를 넣으면 될 것 같습니다.



## 2. 구현목표
디스플레이를 구현하고 새로운 값이 들어올 때마다, 즉 MeasurementsChanged() 메소드가 호출될 때마다 WeatherData에서 디스플레이를 업데이트해야 한다는 것까지는 파악했습니다. 그러려면 어떻게 해야 할까요? 우리가 하려는 일을 조금 더 살펴봅시다.
- WeatherData 클래스에는 3가지 측정값의 게터 메소드가 있습니다.
- 새로운 기상 측정 데이터가 들어올 때마다 MeasurementsChanged()가 호출됩니다. (이 메소드가 어떤 식으로 호출되는지 모르며, 사실 알 필요도 없으며, 아무튼 그냥 그 메소드가 호출된다는 사실만 알고 있습니다.)
- 기상 데이터를 사용하는 디스플레이 요소 3가지를 구현해야 합니다. WeatherData에서 새로운 측정값이 들어올 때마다 디스플레이를 갱신해야합니다ㅣ.
- 디스플레이를 업데이트하도록 MeasurementsChanged()메소드에 코드를 추가해야 합니다.


### 2.1 추가목표

소프트웨어 개발에서는 **변화**는 무조건 생깁니다. 만약 기상 스테이션 프로젝트가 성공하면 디스플레이가 더 늘어날 수도 있고, 디스플레이를 추가할 수 있는 마켓플레이스가 만들어질지도 모릅니다. 그러니 확장 기능을 추가해봅시다.
- **확장성**: 다른 개발자가 새로운 디스플레이를 만들고 싶을 수도 있습니다. 사용자가 마음대로 디스플레이 요소를 더하거나 뺄 수 있게 해주는 것도 괜찮을 것 같습니다. 현재는 3가지 디스플레이 뿐이지만 언젠가는 새로운 디스플레이가 잔뜩 들어오게 될지도 모릅니다.

### 2.2 기상 스테이션용 코드 추가하기
우선 이런 식으로 구현해 볼수도 있을 것 같습니다. Weather-O-Rama 개발자가 준 힌트를 바탕으로 MeasurementsChanged() 메소드에 다음고 같이 코드를 추가했습니다.

```CSharp
public class WeatherData
{
    // 인스턴스 변수 선언

    public void measurementsChanged()
    {
        // weatherData에 있는 게터 메소드를 호출해서 최신 측정값을 가져온다.
        float temp = getTemperature();
        float humidty = getHumidity();
        float pressure = getPressure();

        // 각 디스플레이를 갱신
        currentConditionDisplay.update(temp, humidity, pressure);
        statisticsDisplay.update(temp, humidity, pressure);
        forecastDisplay.update(temp, humidty, pressure);
    }

    // 기타 메소드
}
```

**위 코드의 문제점**
1. 인터페이스가 아닌 구체적인 구현을 바탕으로 코딩을 하고 있습니다.
2. 새로운 디스플레이 항목이 추가될 때마다 코드를 변경해야 합니다.
3. 실행 중에 디스플레이 항목을 추가하거나 제거할 수 없습니다.
4. 바뀌는 부분을 캡슐화하지 않았습니다.


### 2.3 원칙으로 추가 코드 살펴보기

1장에서 배운 개념과 원칙들을 다시 한번 떠올려 봅시다.

```CSharp
public void measurementsChanged()
{
    float temp = getTemperature();
    float humidty = getHumidity();
    float pressure = getPressure();
    
    currentConditionDisplay.update(temp, humidity, pressure);
    statisticsDisplay.update(temp, humidity, pressure);
    forecastDisplay.update(temp, humidty, pressure);
}
```

![image](https://user-images.githubusercontent.com/40491724/184196718-b6e1b4bc-fbed-45ea-896d-cea467bc25e5.png)

실행 중에 디스플레이를 더하거나 빼려면 어떻게 해야할지도 생각해봅시다.

슬슬 옵저버 패턴을 기상 모니터링 애플리케이션에 적용하는 방법을 알아봅시다.