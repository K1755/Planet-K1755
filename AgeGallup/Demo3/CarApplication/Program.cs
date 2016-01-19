using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one Car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Speed = 180;
            car.Color = "Blue";
            car.Engine = 2.0;
            car.FuzzyDices = false;
            car.PrintData();
            /*Console.WriteLine("FuzzyDices =" + car.FuzzyDices);
            Console.WriteLine("Model =" + car.Model);*/

            Car nascar = new Car("Toyota");
            nascar.Speed = 200;
            nascar.Color = "Red";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.Accelerate(50);
            nascar.PrintData();
            /*Console.WriteLine("FuzzyDices =" + nascar.FuzzyDices);
            Console.WriteLine("Model =" + nascar.Model);
            nascar.Speed = 200;*/

            Console.ReadLine();
        }
    }
}
