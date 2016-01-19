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
    class Heater
    {
        //Properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        //Methods prints heater data
        public void PrintData()
        {
            Console.WriteLine("Heater:");
            Console.WriteLine("- temperature :{0} Humidity {1} Is on {2}", Temperature, Humidity, IsOn);
        }

        //Method returns heater data
        public override string ToString()
        {
            return "Temperature : " + Temperature + "Humidity : " + Humidity + "Is on : " + IsOn;
        }
    }
}
//Student.cs
//pää
//int[] luvut = new int[5];

//Student[] students = Student[5];
//students[0] = new student();

//Student student = new Student();
//student.Name = "Pekka";

//students[0] = student;
