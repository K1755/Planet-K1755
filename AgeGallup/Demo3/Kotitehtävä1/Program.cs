using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Indie";
            vehicle.Speed = 300;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();
        }
    }
}
