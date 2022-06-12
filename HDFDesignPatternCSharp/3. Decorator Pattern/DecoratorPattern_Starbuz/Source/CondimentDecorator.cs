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

        public abstract string GetDescription(); // 모든 첨가물 데코레이터에 getDescription() 메소드를 새로 구현하도록 만들 계획입니다.
    }
}
