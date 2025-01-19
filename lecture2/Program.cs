

using System;
using System.Collections.Generic;
using System.Threading;

namespace lecture2
{
    internal class Program
    {
        static double resullt( double x)
        {
            return (x / 1.609);
        }

        static int min (int H , int M)
        {
            return (H * 60) + M  ;
        }

        static string min1 (int M1)
        {
            int houre = M1 / 60;
            int mines = M1 % 60;
            return ($"{houre}Hours, {mines} Minutes");
        }

        static string revares( string S )
        {
            string var = "";
            for (int  i = S.Length-1; i >= 0;  i--)
            {
                var += S[i];
            }
            return var;
        }
   
        static void Main(string[] args)
        {
            //Write a C# program that accepts a double input and converts it into an int. Display both values.

            double A = 3.5;
            int B = Convert.ToInt32(A);
            Console.WriteLine(B);



            //Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.

            int C = 25;
            string D = Convert.ToString(C);

            string E = $"Your number is: {D}";

            Console.WriteLine(E);


            //Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.

            string text = "C# is fun!";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());


            //Write a program that takes a user's full name as input and prints:
            Console.WriteLine("Enter your name :");
            string fName = Console.ReadLine();
            Console.WriteLine(fName);

            Console.WriteLine("Enter your last name :");
            string lName = Console.ReadLine();
            Console.WriteLine(lName);

            string fullName = fName +" "+ lName;

            Console.WriteLine(fullName.Length);

            //Write a program that accepts two integers and prints the smaller of the two.
            //Input: 5, 9
            //Output: "Smaller Number: 5"

            int num1 = 5, num2 = 9;
            if (num1 < num2)
            {
                Console.WriteLine("Smaller Number: " + num1 );
            }


            //Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result.

            Console.WriteLine(resullt(1));


            //Write a method that takes hours and minutes as input and returns the total number of minutes.

            Console.WriteLine(min(5,37));


            //Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            Console.WriteLine(min1(546));

            //Compare Two Numbers
            //  Write a program that prints:
            //  "Equal" if two numbers are the same.
            //  "Greater" if the first is greater.
            //  "Smaller" if the second is greater.
            //  Use only comparison and ternary operators.
            //  Input: 10, 20

            //int number1 = 10, number2 = 20;
            Console.WriteLine("number1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1);

            Console.WriteLine("number2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number2);

            if (number1 == number2) 
            { 
                Console.WriteLine("Equal");
            }

            else if (number1 > number2) 
            { 
                Console.WriteLine("Greater"); 
            }

            else  
            { 
                Console.WriteLine("Smaller");
            }

            // 	Output: "Smaller"Sum of Digits
            //  Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //  Input: 123
            //  Output: "Sum of digits: 6"


            Console.WriteLine("number1 :");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb1);

            Console.WriteLine("number2 :");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb2);

            Console.WriteLine("number1 :");
            int numb3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb3);


            Console.WriteLine( numb1 + numb2 + numb3 );


            // 10 - Reverse a Number
            //Write a program that reverses a number using arithmetic operators and loops.
            //Input: 1234
            //Output: "Reversed Number: 4321"

            Console.WriteLine(revares("123"));

            //Check Divisibility
            //Write a program to check if a number is divisible by another number using logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
            //Input: 25, 5
            //Output: "Divisible"


            Console.WriteLine(" number1:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m1);

            Console.WriteLine(" number2:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m2);

            if (m1 % m2 ==0 )
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }


            // 12 - Find the Middle Value
            //Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            //Input: 15, 20, 10
            //Output: "The middle value is: 15"

            Console.WriteLine(" number1:");
            int XX1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m1);

            Console.WriteLine(" number2:");
            int XX2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m2);

            Console.WriteLine(" number3:");
            int XX3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m2);


            if (XX1 > XX2 && XX1 < XX3)
            {
                Console.WriteLine(XX1);
            }

            else if (XX2 > XX1 && XX2 < XX3)
            {
                Console.WriteLine(XX2);
            }

            else {
                Console.WriteLine(XX3);
            }



        }
    }
}
