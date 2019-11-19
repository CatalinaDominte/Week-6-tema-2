using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Person
    {
        private string Name { get; set; }
        private int? Age { get; set; }
        public Person(string Name,int?Age=null)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public override string ToString()
        {
            if (Age == null)
            {
                return $"Numele: {Name}, Varsta: nespecificat!";
            }
            return $"Numele: {Name}, Varsta: {Age} ani";
        }
    }
}
