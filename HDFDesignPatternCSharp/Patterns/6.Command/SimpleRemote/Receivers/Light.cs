﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("조명이 켜졌습니다.");
        }

        public void Off()
        {
            Console.WriteLine("조명이 꺼졌습니다.");
        }
    }
}
