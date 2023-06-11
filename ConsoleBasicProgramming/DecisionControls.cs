using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class DecisionControls
    {
        static void Main()
        {
           // DecisionControlsSyntax();

            IfElseSample();

            Console.ReadLine();

        }

        private static void IfElseSample()
        {
            //get 2-input from the user  as number and compare who is larger between them

            int first_num, second_num;
            Console.WriteLine("Enter number 1");
            first_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            second_num = Convert.ToInt32(Console.ReadLine());

            if (first_num > second_num)
            {
                Console.WriteLine($"{first_num} is laregr than the {second_num}");
            }

            else
            {
                Console.WriteLine($"{second_num} is laregr than the {first_num}");
            }
        }

        private static void DecisionControlsSyntax()
        {
            if (true)
            {
                //task-1---if executes true condition
            }
            else
            {
                //executes false condition
            }


            //Ladder if else if

            if (true)
            {

            }
            else if (true)
            {

            }
            else if (true)
            {

            }
            else if (true)
            {

            }
            else
            {

            }

            //swtich case is a replacement of ladder if -else

            int choice = 0;
            switch (choice)
            {
                case 1:
                    break;

                case 2:
                    break;
                default:

                    break;
            }

            int x = 3, y = 2;
            int bignumber = x > y ? x : y;
        }
    }
}
