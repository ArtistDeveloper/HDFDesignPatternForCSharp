using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_Starbuz.Source
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "에스프레소";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
