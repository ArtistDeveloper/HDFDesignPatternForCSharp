using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_Starbuz.Source
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "다크 로스트";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
