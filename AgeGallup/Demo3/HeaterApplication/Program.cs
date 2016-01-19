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

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new heater object
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 95;
            heater.PrintData();
            Console.WriteLine(heater.ToString());

            Console.ReadLine();
        }
    }
}
