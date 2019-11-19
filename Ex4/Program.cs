using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Maria Anghelescu", 25);
            Person person2 = new Person("Maria Vasilescu");
            Person person3 = new Person("Alin Dumitrescu",37);
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.ReadLine();
        }
    }
}
