using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("I am from base class constructor");
        }

        public BaseClass(int y)
        {
            Console.WriteLine($"{y} from base class");
        }

        ~BaseClass()
        {
            Console.WriteLine("I am from base class destructor");
        }
    }

    public class DriveClass : BaseClass
    {

        //constructor: base to child
        public DriveClass(int x, int y) : base(y)
        {
            Console.WriteLine($"{x} from Driveclass");
            Console.WriteLine("I am from Drive class constructor");
        }


        //Destructor: child to base
        ~DriveClass()
        {

            Console.WriteLine("I am from Derive class");
        }
    }

    public class CallingClass
    {

        public static void Main()
        {
            DriveClass obj = new DriveClass(2,3);
            Console.ReadLine();

        }
    }
}
