using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFDesignPatternCSharp.Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("날고 있어요!");
        }
    }
}
