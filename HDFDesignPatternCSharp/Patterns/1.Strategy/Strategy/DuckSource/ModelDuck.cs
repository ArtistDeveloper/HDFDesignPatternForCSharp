using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject.DuckSource
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new OriginQuack();
        }

        public override void Display()
        {
            Console.WriteLine("저는 모형오리입니다.");
        }
    }
}
