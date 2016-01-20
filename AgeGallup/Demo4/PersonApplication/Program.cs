using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Age = 35;
            person.Address = "Piippukatu 2";
            person.PhoneNumber = "02012345678";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu 1";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-87654321";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Jouko", "Koodari", "K1234");
            student.Address = "Ceesharpkatu 3";
            student.Age = 24;
            student.PhoneNumber = "030132654789";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

        }
    }
}
