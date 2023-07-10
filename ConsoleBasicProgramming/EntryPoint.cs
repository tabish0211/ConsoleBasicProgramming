using System;
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
            //obj.ShowAccount();

            Console.WriteLine("Enter the amount to be save");
            int amount = Convert.ToInt32(Console.ReadLine());

            //obj.SetAmount(amount);
            //obj.ShowAccount();

            obj.Amount = amount;
            obj.CustomerId = 3001;
             amount = obj.Amount;//obj.GetAmount();
            int customerId = obj.CustomerId;

            Console.WriteLine($"Welcome to mybank customer Id: {customerId} and  " +
                $"amount currently in your account is {amount}");

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
