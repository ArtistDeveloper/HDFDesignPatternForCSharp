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
            Description = "디카페인";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
