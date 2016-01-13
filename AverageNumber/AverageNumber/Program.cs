using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Give first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Give third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2 + num3) / 3);
            Console.ReadLine();

        }
    }
}
