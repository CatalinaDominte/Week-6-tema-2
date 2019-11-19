using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student:IComparable<Student>
    {
        /*Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
         * and by social security number (as second criteria, in increasing order).*/

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        
        public Student(string FirstName, string MiddleName, string LastName, int SSN)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.SSN = SSN;
           
        }
        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return  this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.MiddleName != otherStudent.MiddleName)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }
            if (this.LastName != otherStudent.LastName)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            if (this.SSN != otherStudent.SSN)
            {
                return (this.SSN - otherStudent.SSN);
            }
            return 0;
        }

    }
}
