using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class Person
    {
        public virtual void Welcome()
        {
            Console.WriteLine("I am from Person class");
        }
    }

    class Employee : Person
    {

        //public virtual void Welcome()
        //{
        //    Console.WriteLine("I am from Person class");
        //}
        public new void Welcome()
        {
            Console.WriteLine("I am from Employee class");
        }

        public void Hello()
        {
            Console.WriteLine("hey how are you");
        }
    }

    //class MainClass
    //{

    //    //public static void Main()
    //    //{
    //    //    Person p = new Person();
    //    //    p.Welcome();//I am from Person class

    //    //    //Employee e = new Employee();
    //    //    //e.Welcome();//I am from Employee class
    //    //    //e.Hello();

    //    //    Person person = new Employee();//A base class reference can point to derive class object
    //    //    person.Welcome();//I am from person class
            

    //    //    Console.ReadLine();
    //    //}
    
    //}
}
