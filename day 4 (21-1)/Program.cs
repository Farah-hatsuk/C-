using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace day_4__21_1_
{
    internal class Program
    {
        class student                   // class 
        {
            private string name;                                 //field encapculation
            private int age;
            private int studentID;

            const int minAge = 18;
            const int maxAge = 40;
            public string email {  get; set; }                     //property  

            public string Name                                    //property 
            {
                get { return name; }
                set { name = value; }
            }

            public int Age                                         //property 
            {
                get { return age; }                                 // check if the age is between 18 - 40 
                set { if (value < minAge || value > maxAge)
                    { 
                        age = 20;
                    } else
                    {  age = value; }
                }
            }

           public int StudentID                                    //property 
            {
                get { return studentID; }
                set { studentID = value; }
            }
            
            public student(string Name, int Age, int StudentID)                   // constructor with parameter 
            {
                this.Name = Name;                                                // this => for property    =   value for property 
                this.Age = Age;
                this.StudentID = StudentID;
                

            }

            public void GetDetails()
            {
                Console.WriteLine($" {this.Name} , {this.Age} , {this.StudentID}");          // method 
            }



            ~student()                                                         // de constructor 
            {
                Console.WriteLine("Finish");
            }

        }
        static void Main(string[] args)
        {
            student student1 = new student("Ahmad " , 22 , 1001);                         // make a object 

            student1.GetDetails();                                                       // call the method 
        }

    }
}


//1 - What is class ?                             its a template 
//2 - What is object  ?                           its a instance of class 
//3 - Difference between class && object ?        we put the class above the nain   and the object under the main 
//4 - Mention the OOP Principles  ?               Encapsulation / Inheritance / Polymorphism / Abstraction
//5-	What is property                          its a way to control access to fildes inside a class by { get ; set ;}
//6-	What is field                             editable data  بيانات يمكن تعديلها 
//7-	What is constructor                       is a special method that used to initilize objects when we creat a class 
//8-	What is encapsulation                     Encapsulation in C# is a mechanism that combines data and methods into a single unit called a class. + to make sure that "sensitive" data is hidden from users. 


