using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_Starbuz.Source
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage; // 각 데코레이터가 감쌀 음료를 나타내는 Beverage 객체를 여기에서 지정합니다.

        /// <summary>
        /// 모든 첨가물 데코레이터에 getDescription() 메소드를 새로 구현하도록 만들 계획입니다.
        /// virtual로 선언된 부모 함수인 GetDescription()을 override를 합니다. 
        /// override를 통해 함수를 재정의하면 부모쪽 함수의 호출이 아닌 자식의 함수가 호출되므로 데코레이터 패턴을 구현할 수 있게 됩니다.
        /// </summary>
        /// <returns></returns>
        public abstract override string GetDescription(); 
    }
}
