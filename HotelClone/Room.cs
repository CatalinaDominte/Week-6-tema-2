using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClone
{
    class Room
    {
       

        public string Name { get; set; }
        public int Rate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Room(string Name, int Rate, int Adults, int Children)
        {
            this.Name = Name;
            this.Rate = Rate;
            this.Adults = Adults;
            this.Children = Children;

        }

        public decimal GetPriceForDays(int numberOfDays)
        {
            return Rate * numberOfDays;
        }
        public void Print()
        {
            Console.WriteLine($"Camera:{this.Name}, Cost: {Rate}, Capacitate: {Adults} adulti, {Children} copii");
        }
    }
}
