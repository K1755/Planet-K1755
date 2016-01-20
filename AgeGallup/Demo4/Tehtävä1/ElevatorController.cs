/* 
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

namespace Tehtävä1
{
    class ElevatorController
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;
        private int floor;
        
        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Too small");
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Too big");
                }
                else
                {
                    floor = value;
                }

                /*if (value <= maxFloor && maxFloor >= 5) floor = value;
                else Console.WriteLine("There is no basemante or floors 6 and above.");
                floor = maxFloor;*/
            }
        }
    }
}
