

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace day_3__20_1_
{
    internal class Program
    {
        class Hotel
        {
            public int roomNumber;
            public string roomType;
            public int pricePerNight;
            public string roomIsBook;

            public const string HotelName = " Grand Stay Hotel";

            public void print()
            {
                Console.WriteLine($" you have {roomIsBook} in {HotelName} and your room is {roomNumber} , type {roomType} the price for one night is {pricePerNight} . ");
            }

        }

        static void Prims(int n1, int n2)
        {

            for (int i = n1; i <= n2; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                }
                if ( (i % 2 == 0) ||(i % 5 == 0)||(i % 3 == 0))
                {
                    continue;
                }

                int counter = 0;
                for (int j = 2; j <= i; j++)
                {
                    if ((j % i) == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine(i);

                }

            }
        }
        static int MaxValue(int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Hotel room1 = new Hotel();
            room1.roomNumber = 1;

            Console.WriteLine("choose your room type ( Single, Double, Suite ): ");
            string Type = Console.ReadLine();
            room1.roomType = Type;

            room1.pricePerNight = 50;

            room1.roomIsBook = "booked";

            Hotel room2 = new Hotel();
            room2.roomNumber = 2;

            Console.WriteLine("choose your room type ( Single, Double, Suite ): ");
            string Typee = Console.ReadLine();
            room2.roomType = Typee;

            room2.pricePerNight = 50;

            room2.roomIsBook = "not booked "; 

            room1.print();


            // 1 - Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.
            //•	Example Input: 7
            //•	Output: The number 7 is odd.

            Console.WriteLine("number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine($"The number {number} is odd ");
            }


            // 2 - Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
            //•	Example Input: 4, -3, 7, 2, 0
            //•	Output: 0


            int[] elements = new int[5];
            Console.WriteLine("Enter 5 elements:");
            elements[0] = Convert.ToInt32(Console.ReadLine());
            elements[1] = Convert.ToInt32(Console.ReadLine());
            elements[2] = Convert.ToInt32(Console.ReadLine());
            elements[3] = Convert.ToInt32(Console.ReadLine());
            elements[4] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(elements);
            Console.WriteLine(elements[1]);







            // 3 - Write a program that calculates the factorial of a given number using a for loop.
            //•	Example Input: 5
            //•	Output: 120(5 × 4 × 3 × 2 × 1 = 120)



            int numbers = 5;
            int sum = 1;
            for (int i = 1; i <= 5; i++)
            {
                sum = sum * i;
            }

            Console.WriteLine(sum);


            //  4 - Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.
            //•	Example Input:
            //o Start: 10
            //o End: 30
            //•	Output: 11, 13, 17, 19, 23, 29



            Prims( 10, 30);




            // 5 - Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            //•	Example Array: { 3, 1, 4, 1, 5, 9}
            //•	Output: 9

            int[] ints = { 3, 1, 4, 1, 5, 9 };
            int larg = int.MinValue;

            foreach (int i in ints)
            {
                larg = Math.Max(larg, i);

            }

            Console.WriteLine(larg);




            //Array.Sort(ints);
            //Console.WriteLine(ints[5]);


            //6 - Write a program that prints the following number pattern using nested loops:
            //For n = 5, the output should be:
            // 1
            // 2 3
            // 4 5 6
            // 7 8 9 10
            // 11 12 13 14 15

            int s = 0;
            for (int i = 0; i <= 5; i++)
            {
                string X = "";
                for (int j = 1; j <= i; j++)
                {
                    s++;
                    X += Convert.ToString(s) + "  ";
                }

                Console.WriteLine(X);

            }



        }
    }
}
