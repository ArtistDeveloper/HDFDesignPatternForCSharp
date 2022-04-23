﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject.DuckSource
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new OriginQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("저는 물 오리입니다.");
        }
    }
}
