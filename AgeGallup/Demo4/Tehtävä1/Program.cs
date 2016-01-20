/* 
 * Copyright (C) Joni Korkiakoski
 * 
 * This file is part of the my school project.
 * 
 * Created: <<20.1.2016>> 
 * Authors: <<Joni Korkiakoski>> 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorController elevatorcontroller = new ElevatorController();

            do
            {
                Console.Write("Give a number > ");
                string line = Console.ReadLine();
                int floor = int.Parse(line);
                elevatorcontroller.Floor = floor;
                Console.WriteLine(elevatorcontroller.Floor);
                

            } while (elevatorcontroller.Floor >= 0);
            

            Console.ReadLine();
        }
    }
}
