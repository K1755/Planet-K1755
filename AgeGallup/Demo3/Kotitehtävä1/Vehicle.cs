using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä1
{
    class Vehicle
    {
        //Properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //Method prints Vehicle properties
        public void PrintData()
        {
            Console.WriteLine("Vehicle: ");
            Console.WriteLine("Name: {0} | Speed: {1}km/h | Tyres: {2}", Name, Speed, Tyres);
        }

            //Method returns Vehicle properties
            public override string ToString()
        {
            return "Name: " + Name + " | Speed: " + Speed + "km/h | Tyres: " + Tyres;
        }
    }

}
