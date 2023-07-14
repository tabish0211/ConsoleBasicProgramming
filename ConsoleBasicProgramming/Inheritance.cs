using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    public class Shape
    {
        public int Length { get; set; }
        public int width { get; set; }

    }


    //single level
    public class RectAngle :Shape
    {   
        public void Area()        
        {

            int area = Length * width;
        }
    }

    public class Squeare :Shape
    {

        public void Area()
        {
            //length==width
            int area = Length * width;
        }
    }

    //multi level
    class A
    { }

    class B : A { }
    class C : B { }


    //Multiple Inheritance--No
    //class D :B,C
    //{
    
    //}



}
