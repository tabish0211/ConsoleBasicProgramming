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

            //elsdest of three borthers, Ram=12, ramesh=10, suresh=9
            // Ram=10, ramesh=12, suresh=9
            // Ram=10, ramesh=9, suresh=12

            //LadderIfElse();
            //NESTEDIFELSE();

            Console.ReadLine();

        }

        private static void LadderIfElse()
        {
            int Ram = 9, ramesh = 10, suresh = 12;

            //if (Ram > ramesh && Ram > suresh)
            //{
            //    Console.WriteLine($"Ram age {Ram} is eldest one");

            //}
            //else if (ramesh > Ram && ramesh > suresh)
            //{
            //    Console.WriteLine($"Ramesh age {ramesh} is eldest one");
            //}

            //else
            //{
            //    Console.WriteLine($"Suresh age {suresh} is eldest one");
            //}

            string info = (Ram > ramesh) ? (Ram > suresh ? $"Ram age {Ram} is eldest one" : $"Suresh age {suresh} is eldest one") :
                (ramesh > suresh ? $"Ramesh age {ramesh} is eldest one" : $"Suresh age {suresh} is eldest one");
            Console.WriteLine(info);
        }

        private static void NESTEDIFELSE()
        {
            int Ram = 10, ramesh = 12, suresh = 9;

            if (Ram > ramesh)
            {

                if (Ram > suresh)
                {
                    Console.WriteLine($"Ram age {Ram} is eldest one");

                }

                else
                {
                    Console.WriteLine($"Suresh age {suresh} is eldest one");
                }
            }
            else
            {
                if (ramesh > suresh)
                {
                    Console.WriteLine($"Ramesh age {ramesh} is eldest one");

                }

                else
                {
                    Console.WriteLine($"Suresh age {suresh} is eldest one");
                }
            }
        }

        private static void IfElseSample()
        {
            //get 2-input from the user  as number and compare who is larger between them

            int first_num, second_num;
            Console.WriteLine("Enter number 1");
            first_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            second_num = Convert.ToInt32(Console.ReadLine());

            //if (first_num > second_num)
            //{
            //    Console.WriteLine($"{first_num} is laregr than the {second_num}");
            //}

            //else
            //{
            //    Console.WriteLine($"{second_num} is laregr than the {first_num}");
            //}

            string info=first_num > second_num ? $"{first_num} is laregr than the {second_num}" : $"{second_num} is laregr than the {first_num}";
            Console.WriteLine(info);
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
