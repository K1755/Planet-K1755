﻿/* 
 * Copyright (C) Joni Korkiakoski
 * 
 * This file is part of the my school project.
 * 
 * Created: <<19.1.2016>> 
 * Authors: <<Joni Korkiakoski>> 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication1
{
    class Car
    {
        //Max speed
        private readonly int maxSpeed = 200;
        //Member Field
        private int speed;
        //Property
        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value <= maxSpeed) speed = value;
                else Console.WriteLine("Too much speed - set to max!");
                speed = maxSpeed;
            }
        }
    }
}
