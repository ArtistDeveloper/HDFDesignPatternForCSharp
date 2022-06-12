using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_Starbuz.Source
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "디카페인";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
