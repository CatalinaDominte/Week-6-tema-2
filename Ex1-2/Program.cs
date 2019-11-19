using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Define a class Student, which contains data about a student – first, middle and last name,
            SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
                Use an enumeration for the specialties, universities and faculties.*/

            Student Cristi = new Student("Cristi", "Ionut", "Georgescu", 222584763, 0744404158, ".Net", Student.Universities.MIT, Student.Faculties.Phisics, Student.Specialties.Astrophysics);
            //Student Cristi1 = new Student("Cristi", "Ionut", "Georgescu", 222584763, 0744404158, ".Net", Student.Universities.Harvard, Student.Faculties.Chemistry, Student.Specialties.Biochemistry);
            // Student Maria = new Student("Maria", "Alina", "Georgescu",122584763, 0724404158, ".Net", Student.Universities.Harvard, Student.Faculties.Chemistry, Student.Specialties.Biochemistry);
            
            
            
            
            Cristi.PermanentAddress.EntireAddress ="Strada Barbu, Numarul 7";
            Cristi.PermanentAddress.Cod = 71154;
            var Ioan =(Student)Cristi.Clone();
            Ioan.FirstName = "Ioan";
            Ioan.PermanentAddress.EntireAddress = "Strada Crizantemei, Numarul 10";
            Cristi.University = Student.Universities.Cambridge;
            
            Console.WriteLine(Ioan.ToString());
            Console.WriteLine(Cristi.ToString());


            //Console.WriteLine(Cristi.Equals(Cristi1));
            //Console.WriteLine(Cristi.Equals(Maria));
            //Console.WriteLine(Cristi.GetHashCode());
            //Console.WriteLine(Cristi1.GetHashCode());
            //Console.WriteLine(Maria.GetHashCode());
            //Console.WriteLine(Cristi== Cristi1);
            //Console.WriteLine(Cristi != Cristi1);
            //Console.WriteLine(Cristi.ToString());
           

            Console.ReadLine();
        }
    }
}
