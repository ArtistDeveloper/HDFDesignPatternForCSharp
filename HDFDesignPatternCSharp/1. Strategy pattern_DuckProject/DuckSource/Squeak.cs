﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject.DuckSource
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("삑");
        }
    }
}
