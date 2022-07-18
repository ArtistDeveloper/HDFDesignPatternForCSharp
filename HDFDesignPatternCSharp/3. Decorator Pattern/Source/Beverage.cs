using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_Starbuz.Source
{
    /// <summary>
    /// getDescription()과 Cost()라는 2개의 메소드를 가집니다.
    /// getDescription()은 이미 구현되어 있지만 Cost()는 서브클래스에서 구현해야 합니다.
    /// </summary>
    public abstract class Beverage
    {
        protected string description = "제목 없음";
        // private string Description { get; set; } = "제목없음"; // C# 6이상부터는 자동 구현 프로퍼티를 변수처럼 초기화 할 수 있습니다.
        // public string Description { get => description; protected set => description = value; }

        /// <summary>
        /// 책에서는 virtual이 붙어있지 않지만, C#에서 책처럼 구동되게하려면 virtual을 붙여주어야 합니다.
        /// virtual 키워드를 붙이지 않는다면, 상속받는 곳에서 "GetDescription()" 메소드를 new를 통해 정의할 수 밖에 없는데, 
        /// new를 통해 함수를 재정의하게 된다면 부모쪽의 함수가 호출되므로 데코레이터 패턴의 재귀적인 특성을 이용할 수 없습니다.
        /// 함수는 override로 재정의 시 자료형이 부모의 타입으로 업캐스팅 되어도 자식의 함수가 호출되기 때문에, 
        /// 이 상황에서 자식 클래스에서 함수를 재정의 할 때는 new보다는 override를 사용하도록 만들 수 있어야 합니다.
        /// </summary>
        /// <returns></returns>
        public virtual string GetDescription() 
        {
            return description;
        }

        public abstract double Cost();
    }
}
