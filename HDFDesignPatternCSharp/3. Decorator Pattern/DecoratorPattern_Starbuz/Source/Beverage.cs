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
        private string description = "제목 없음";
        // private string Description { get; set; } = "제목없음"; // C# 6이상부터는 자동 구현 프로퍼티를 변수처럼 초기화 할 수 있습니다.

        public string Description { get => description; private set => description = value; }

        public abstract double Cost();
    }
}
