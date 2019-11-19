using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Room appartment1 = new Room("Appartament 1", 1000, 2, 2);

            Room appartment2 = new Room("Appartament 2", 800, 4, 4);


            Room appartment3 = new Room("Appartament 3", 1200, 3, 0);

            Room appartment4 = new Room("Appartament 4", 1100, 3, 2);
          

            Hotel BlueLagoon = new Hotel()
            {
                Name = "Blue Lagoon",
                City = "Cebu",
                Stars = "4",
                Rooms = new List<Room>() { appartment1, appartment2, appartment4 }
            };



            Hotel SummerEco = new Hotel()
            {
                Name = "Summer Eco Lodge",
                City = "El Nido",
                Stars = "5",
                Rooms = new List<Room>() { appartment1, appartment2, appartment3 }
            };

            var HotelClone =(Hotel) SummerEco.Clone();
            SummerEco.Print();
            HotelClone.Rooms.Add(appartment4);
            HotelClone.Name = "Traian";
            HotelClone.Print();

            Console.ReadLine();
        }
    }
}
