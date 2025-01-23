using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace day_6___23__1__
{
    internal class Program
    {
        //•	Create a Calculator class with methods to add:
        class Calculator
        {
            public int Add(int a, int b) { return a + b; }
            public double Add(int a, int b, int c) { return a + b + c; }
            public double Add(double a, double b) { return a * b; }

        }

        // Create a Shape class with a method draw(). Create two child classes:
        class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("draw the shape : ");
            }
        }

        class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("draw the shape : circle");
            }
        
        }

        class Rectangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("draw the shape : rectangle");
            }
        }

        // 	Create an abstract class Animal with:
        abstract class Animal
        {
            public abstract void makeSound();

            public void sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }

        class Dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        // Create an interface Playable with:

        interface IPlayable
        {
            void play();
        }
         
        class Guirar : IPlayable
        {
            public void play() { Console.WriteLine("Playing the guitar."); }
        }

        class Piano : IPlayable
        {
            public void play() { Console.WriteLine("Playing the piano."); }
        }


        static void Main(string[] args)
            {

            //•	Create a Calculator class with methods to add:
            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            calculator.Add(2, 3 ,4 );
            calculator.Add(3.1 , 4.5  );

            // Create a Shape class with a method draw(). Create two child classes:

            Shape shape1 = new Shape();  
            Shape circle = new Shape();  
            Shape rectangle = new Shape();  

            shape1.draw();
            circle.draw();
            rectangle.draw();

            // 	Create an abstract class Animal with:

            Cat cat = new Cat();
            cat.sleep();
            cat.makeSound();
            Dog dog = new Dog();
            dog.makeSound();
            dog.sleep();

            // Create an interface Playable with: 
            Guirar guitar = new Guirar();
            guitar.play();

            Piano piano = new Piano();
            piano.play();
        }
    }
    }
