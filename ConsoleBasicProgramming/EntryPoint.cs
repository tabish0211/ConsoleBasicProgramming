﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class EntryPoint
    {
        static void Main()
        {
           // BankDemo obj = new BankDemo();//constructor without parameter --Default COnstructor
            BankDemo obj = new BankDemo(2001,100);
            obj.ShowAccount();
            Console.ReadLine();
        }

    }





    //class EntryPoint
    //{
    //    static void Main()
    //    {
    //        //create object in order to call non sttaic method from Main
    //        //className obj = new ClassName();
    //        NonStaticMethodsDemo obj = new NonStaticMethodsDemo();
    //        //To access non static method /Instance method--obj.MethodName()
    //        //obj.Sum();
    //        //obj.Sum(1, 2);
    //        //obj.Sum(1);
    //        //double val = 111111111111111111111111111111111111111111111111111111111.05;
    //        //obj.Sum(val);

    //        //int output = obj.Add(2, 3);
    //        //static methods can be access by ClassName.MethodName
    //        NonStaticMethodsDemo.Message();
    //        //Console.WriteLine(output);
    //        Console.ReadLine();
    //    }

    //}
}
