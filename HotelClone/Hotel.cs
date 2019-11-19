using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClone
{
    class Hotel:ICloneable
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Stars { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public Hotel()
        {

        }

        public object Clone()
        {
            Hotel H1 = new Hotel();
            H1.Name = this.Name;
            H1.City = this.City;
            H1.Stars = this.Stars;
            H1.Rooms = new List<Room>();
            foreach (var item in Rooms)
            {
                H1.Rooms.Add(new Room(item.Name, item.Rate, item.Adults, item.Children));
            }
            return H1;
        }


        public void PricesForNoRoom(int no)
        {
            Console.WriteLine($"Pretul camerelor pe {no} zile este: ");
            decimal price = 0;
            foreach (var item in Rooms)
            {
                price = item.Rate * no;
                Console.WriteLine($"{item.Name} - {price} ({item.Rate})");
            }

        }
        public void Print()
        {
            Console.WriteLine($"Hotelul: {this.Name}, din orasul: {this.City}, are {this.Stars} stele. Camerele disponibile sunt urmatoarele:");

            foreach (var room in Rooms)
            {
                Console.WriteLine(room.Name);
            }
        }
    }
}
