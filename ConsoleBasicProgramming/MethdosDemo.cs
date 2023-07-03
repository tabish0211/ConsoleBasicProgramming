using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class MethdosDemo
    {

        //static methods call static method directly
        //non static method---? It call via creating object
        static void Main()
        {


            int s;
            int z=4;

            //Sum_withOutParam(out s);
            Sum_withMorethanoneOutParam(out s, out z);
            Console.WriteLine($"summation={s} and diff ={z}");

            Console.ReadLine();

        }


        //No-Return--Sum is not going to retrun anything to the Main
        static void Sum()
        {

            int x, y, s = 0;
            x = 1;
            y = 2;
            s = x + y;
            Console.WriteLine(s);

        }

        static int  Sum_withRetrun()
        {

            int x, y, s = 0;
            x = 1;
            y = 2;
            s = x + y;

            return s;
            

        }

        //Pass by value
        static int Sum_withRetrunWithParams(int x,int y)
        {
            int s = x + y;
            return s;

        }

        //Pass by reference---1001,1002

        static int Sum_withRetrunWithReferenceParams(ref int x, ref int y)
        {
            x = 5;
            y = 6;
            int s = x + y;
            
            return s;
        }

        static void Sum_withOutParam(out int s)
        {

            int x, y;
            x = 1;
            y = 2;
            s = x + y;          

        }

        static void Sum_withMorethanoneOutParam(out int s,out int z)
        {

            int x, y;
            x = 1;
            y = 2;
            s = x + y;
            z = x - y;

        }
    }
}
