using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFDesignPatternCSharp.Ducks
{
    public class OriginQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("꽥");
        }
    }
}
