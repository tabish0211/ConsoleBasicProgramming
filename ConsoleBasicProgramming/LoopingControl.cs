using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class LoopingControl
    {
        static void Main()
        {
            //Looping --repitive task ---
            //for,while,do-while,foreach
            //2 table
            //int x = 1;
            //Console.WriteLine(2 * x);
            //x = 2;
            //Console.WriteLine(2 * x);
            //x = 3;
            //Console.WriteLine(2 * x);

            //int x = 1;
            ////x = x + 1;
            ////x += 1;
            ////x = x++;//post incremnet  x+1
            ////x = ++x;//x+1

            //int y = x + x++ + ++x + x++;
            //Console.WriteLine(y);//5
            //Console.WriteLine(x);//3

            //assignment -input --number 
            //for (int x = 1; x < 11; x++)
            //{
            //    Console.WriteLine($"2*{x}={2*x}");
            //}

            //
           // int x = 1;
            //do
            //{
            //    //task
            //    Console.WriteLine($"2*{x}={2 * x}");
            //    x++;
            //} while (x < 11);//Bottom testing 

            //Top testing
            //while (x < 11)
            //{
            //    Console.WriteLine($"2*{x}={2 * x}");
            //    x++;
            //}

            ////when you know number of times
            //for (int i = 0; i < length; i++)
            //{

            //}

            ////when you dont know the how much times loop should execute 
            //while (true)
            //{

            //}


            //array-?
            //foreach (var item in collection)
            //{

            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i==6)
            //    {
            //        break;//forcefully loop or curly brace break
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    continue;//skip
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
