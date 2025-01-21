using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___objects
{
    internal class Program
    {   // 1 

        //class Hotel
        //{
        //    public int roomNumber;
        //    public string roomType;
        //    public int pricePerNight;
        //    public string roomIsBook;

        //    public const string HotelName = " Grand Stay Hotel";

        //    public void print()
        //    {
        //        Console.WriteLine($" you have {roomIsBook} in {HotelName} and your room is {roomNumber} , type {roomType} the price for one night is {pricePerNight} . ");
        //    }

        //}

        // 2 
        class Hotel
        {
            public int RoomNumber { get; set; }
            public string RoomType { get; set; }
            public double PricePerNight { get; set; }
            public bool RoomIsBook { get; set; }

            public Hotel(int room_number, string room_type, double price_pernight, bool room_isbook)
            {
                RoomNumber = room_number;
                RoomType = room_type;
                PricePerNight = price_pernight;
                RoomIsBook = room_isbook;

            }

            public Hotel() {
                RoomNumber =1;
                RoomType = " Single";
                PricePerNight = 50.2;
                RoomIsBook = true;

            }



            ~Hotel() {
                Console.WriteLine("finish");
            }

        }
            static void Main(string[] args)
        {
            //Hotel room1 = new Hotel();
            //room1.roomNumber = 1;

            //Console.WriteLine("choose your room type ( Single, Double, Suite ): ");
            //string Type = Console.ReadLine();
            //room1.roomType = Type;

            //room1.pricePerNight = 50;

            //room1.roomIsBook = "booked";

            //Hotel room2 = new Hotel();
            //room2.roomNumber = 2;

            //Console.WriteLine("choose your room type ( Single, Double, Suite ): ");
            //string Typee = Console.ReadLine();
            //room2.roomType = Typee;

            //room2.pricePerNight = 50;

            //room2.roomIsBook = "not booked ";

            //room1.print();

            Hotel hotel = new Hotel();
            Console.WriteLine(hotel.RoomType , hotel.RoomNumber , hotel.PricePerNight , hotel.RoomIsBook);
            Hotel room1 = new Hotel(1 , "Double" , 50.2 , false);
            Console.WriteLine(room1.RoomType + room1.RoomNumber + room1.PricePerNight + room1.RoomIsBook);

            
        }
    }
}
