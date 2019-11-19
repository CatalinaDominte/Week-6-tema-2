using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Student:ICloneable
    {
       

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public int Mobile { get; set; }
        public Address PermanentAddress { get; set; }
        public string Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Specialty { get; set; }
        public Student(string FirstName, string MiddleName, string LastName, int SSN, int Mobile, string Course, Universities University, Faculties Faculty, Specialties Specialty)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.SSN = SSN;
            this.Mobile = Mobile;
            this.PermanentAddress = new Address();
            this.Course = Course;
            this.University = University;
            this.Faculty = Faculty;
            this.Specialty = Specialty;
        }

        public Student()
        {
        }

        public object Clone()
        {
         
            Student student = new Student();
            student.FirstName = this.FirstName;
            student.MiddleName = this.MiddleName;
            student.LastName = this.LastName;
            student.SSN = this.SSN;
            student.Mobile = this.Mobile;
            student.PermanentAddress= new Address();
            student.PermanentAddress.EntireAddress = this.PermanentAddress.EntireAddress;
            student.PermanentAddress.Cod = this.PermanentAddress.Cod;
            student.Course = this.Course;
            student.University = this.University;
            student.Faculty = this.Faculty;
            student.Specialty = this.Specialty;

           return student;

        }

        public override bool Equals(object param)
        {
            var student = param as Student;
            if (student == null)
                return false;
            if (!Equals(LastName, student.LastName))
                return false;
            if (SSN != student.SSN)
                return false;
            if (Mobile != student.Mobile)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode() ^ Mobile.GetHashCode();
        }
        public static bool operator ==(Student student1,
            Student student2)
        {
            return Equals(student1, student2);
        }

        public static bool operator !=(Student student1,
            Student student2)
        {
            return !Equals(student1, student2);
        }
        public override string ToString()
        {
            return ($"Descriere: {this.FirstName} {this.LastName} - {this.SSN} {this.University}, {this.Faculty}, {this.Specialty} ////{this.PermanentAddress.EntireAddress} -{this.PermanentAddress.Cod} ");
        }

        public enum Universities
        {
            Harvard, Cambridge, MIT
        }
        public enum Faculties
        {
            Mathematics, Phisics, Informatics, History, Geographiy, Chemistry
        }
        public enum Specialties
        {
            Geochemistry, Biochemistry, Astrophysics, PhisicalChemistry, Geology, UrbanDesigne, Robotics
        }
    }
}
