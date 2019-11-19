using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Cristi = new Student("Cristi", "Ionut", "Georgescu", 222584763);
            Student Cristi1 = new Student("Cristi", "Ionut", "Marinescu", 222584730);
            Student Cristi2 = new Student("Cristi", "Ionut", "Georgescu", 222584760);
            Student Cristi3 = new Student("Cristi", "Alin", "Georgescu", 222584750);

            Student Maria = new Student("Maria", "Alina", "Georgescu",122584763);
            List<Student> Students = new List<Student>();
            Students.Add(Cristi);
            Students.Add(Cristi1);
            Students.Add(Maria);
            Students.Add(Cristi2);
            Students.Add(Cristi3);

            Students.Sort();
            Console.WriteLine("After Sorting");
            foreach (Student x in Students)
            {
                Console.WriteLine($"{x.FirstName} {x.MiddleName} {x.LastName} - {x.SSN}" );
            }
            Console.ReadLine();
        }
    }
}
