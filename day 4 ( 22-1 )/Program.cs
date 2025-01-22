using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace day_4___22_1__
{
    internal class Program
    {
        class  Vehicle
        {
            public string brand { get; set; }
            public string model { get; set; }


            public void Start()
            {
                Console.WriteLine("Vehicle is starting.");
            }

            public void print ()
            {
                Console.WriteLine($"the brad is {brand} and the model is {model} " );
            }


        }
        class Car:Vehicle

        {
            public int doors { get; set; }
        }


        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.brand = "mercedes";
            vehicle.model = "G Class ";
            vehicle.Start();



            Car car = new Car();
            car.brand = "BMW";
            car.model = "model";
            car.doors = 4;

            
            

        }
    }
}

//What is constructor  ?  constructor is a special method in a class that is automatically called when an object is created. It is used to initialize the object's fields or properties. 

//What are the basic concepts of OOPs  ?   1. Encapsulation    2. Inheritance    3.Polymorphism   4. Abstraction

//What is the Encapsulation  ?   Encapsulation in C# is a mechanism that combines data and methods into a single unit called a class , It's a way to organize and protect your data and methods.

//What is the sealed class  ?   Sealed Class: A sealed class cannot be inherited. This ensures that no other class can extend its functionality.

//What is the Inheritance concept   ?  class can inherit properties and behaviours (METHODS) from another class , with a superclass (also called a base class or parent class) and one or more subclasses (also known as derived classes or child classes)

