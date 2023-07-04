using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class NonStaticMethodsDemo
    {

        public static void Message()
        {
            Console.WriteLine("Welcome to my Application");
        }
        //Method overloading--Polymorphism
        void Sum()
        {
            int x = 1, y = 2;
            int s = x + y;
            Console.WriteLine(s);
        
        }

        void Sum(int x,int y)
        {          
            int s = x + y;
            Console.WriteLine(s);

        }

        void Sum(int x)
        {
            int s = x+1;
            Console.WriteLine(s);

        }

        void Sum(double x)
        {
            double s = x + 2;
            Console.WriteLine(s);

        }

        //C# Adds private protection level
       public int Add(int x, int y)
        {
            int s = x + y;
            return s;
        }
    }
}
