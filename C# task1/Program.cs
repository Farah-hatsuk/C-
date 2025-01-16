
using System;

namespace C__task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name :");
            string text = Console.ReadLine();
            Console.WriteLine(text);


            Console.WriteLine("************* 2 ***********");


            //Double
            double A = 1.2;
            Console.WriteLine(A);

            //String 
            string B = "Farah";
            Console.WriteLine(B);

            //Char
            char C = 'F';
            Console.WriteLine(C);

            //Bool
            bool D = true;
            Console.WriteLine(D);

            //Int
            int E = 4;
            Console.WriteLine(E);

            //Const
            const int F = 5;
            Console.WriteLine(F);




            Console.WriteLine("************ 3 ***********");
            //Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] cars = {"Mercedes" ,"BMW" , "Audi" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("********* 4 ***********");
            //Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially. Go to the editor

            Console.WriteLine("Input your firstname: ");
            string Fname = Console.ReadLine();

            Console.WriteLine("tInput your lastname: ");
            string Lname = Console.ReadLine();

            Console.WriteLine("tInput your year of birth: ");
            int age  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fname + Lname + age);



            Console.WriteLine("********* 5 ***********");
            //Write a program in C # to store elements in an array and print it. 

            int[] elements = new int[10];
            Console.WriteLine("Enter 10 elements:");

            for (int i = 0; i < elements.Length; i++)
            {

                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
















        }
    }
}
