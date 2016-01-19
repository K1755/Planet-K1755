using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //Field Member

        //Properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }

        //Constructor
        public Car()
        {
            FuzzyDices = true;
        }

        //Parametric Constructor
        public Car(string model)
        {
            Model = model;
        }

        //Method Display Car Data
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- model :" + Model);
            Console.WriteLine("- color :" + Color);
            Console.WriteLine("- engine :" + Engine);
            Console.WriteLine("- speed :" + Speed);
            Console.WriteLine("- fuzzydices :" + FuzzyDices);
        }

        //Method Gives More Speed
        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }
    }
}
