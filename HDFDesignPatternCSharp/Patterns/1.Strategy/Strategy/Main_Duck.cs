using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject.DuckSource
{
    class Main_Duck
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Duck rubber = new RubberDuck();

            Console.WriteLine("Mallard Duck");
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine("Rubber Duck");
            rubber.PerformQuack();
            rubber.PerformFly();

            Console.WriteLine("---------------");
            rubber.FlyBehavior = new FlyRocketPowered();
            rubber.PerformFly();
        }
    }
}
