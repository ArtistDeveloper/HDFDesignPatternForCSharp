using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject.DuckSource
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck() { }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠.");
        }
    }
}
