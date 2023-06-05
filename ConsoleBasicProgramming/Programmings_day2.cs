using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class Programmings_day2
    {
        static void Main()
        {

            // Swapping();
            //SumOfDigits();
            //CalCulateGrossSalary();
           // RectAngleCalculation();
            Console.ReadLine();
            

        }

        static void RectAngleCalculation()
        {
            //Rectangle--area, perimeter---
            //given---l,b
            Console.WriteLine("enter len of rectangle");
            int len = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter brdth of rectangle");
            int breath = Convert.ToInt32(Console.ReadLine());

            int area_rect = len * breath;
            int perimetre = 2 * (len + breath);

            Console.WriteLine($"area of rectangle whose sides are {len} and {breath} is {area_rect}");
            Console.WriteLine($"Permiter of rectangle whose sides are {len} and {breath} is {perimetre}");

        }
        //Assignment circle perimeter and area--radius should be taken 
        static void CalCulateGrossSalary()
        {   
            Console.WriteLine("Enter Ramesh's basic salary");
            int basicSal = Convert.ToInt32(Console.ReadLine());//int in c# occupies 4 bytes in memory--1byte--8 bits 4byte--8*4==32
            double da = 0.4 * basicSal;//big decimal---8 bytes--da--40%
            double hra = 0.2 * basicSal;

            double grossSalary = basicSal + da + hra;
            Console.WriteLine($"Gross salary of Ramesh is {grossSalary}");

        
        }

        static void SumOfDigits()
        {
            int number = 23456;
            int a, b, c, d, e;

             a = number % 10;//remainder--6
            number  = number /10;//2345
            b = number % 10;//5
            number = number / 10;//234
            c = number % 10;//4
            number = number / 10;//23
            d = number % 10;//3
            number = number / 10;//2
            e = number;
            //sum of digits
            int output = a+b+c+d+e;//6+5+4+3+2

            Console.WriteLine($"sum of the 5 digits number is {output}");
        }

        //1.Take the input from the user and then do sum of the digits
        //2.Take the 4 digits number from user and print sum of the 1st and last digits--1234--5
        //3.Take the 4 digits number from user and print in the reverse order--1234---4321

        static void Swapping()
        {  
            //swapping of two numbers
            int first_num = 2, second_num = 3;

            Console.WriteLine($"Before swapping : first number ={first_num} and second number={second_num}");
            int temp;
            temp = first_num;//temp---2 fist_num---2
            first_num = second_num;//first_num==3  second_num---3
            second_num = temp;
            Console.WriteLine($"After swapping : first number ={first_num} and second number={second_num}");
        }
    }

    //Assignment : DO swapping program without using third variable 
}
