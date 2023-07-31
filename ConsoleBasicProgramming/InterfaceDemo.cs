using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    public interface IReader
    {

        void Read();

    }

    public interface Iwriter
    {
        void Write();


    }



    //Interface is a contract to a class, it should define interface members the way its been declared in interface
    class MSwordOpration : Iwriter, IReader
    {
        public void Read()
        {

        }

        public void Write()
        {

        }
    }

    //IInputOutputOperation obj= new PDFOpration();
    public class PDFOpration : Iwriter, IReader
    {
        public void Read()
        {

        }

        public void Write()
        {

        }

        public void SensitiveData()
        { }
    }

    public static class Instance
    {
        public static IReader GetInstanceReader()
        {   
            return new PDFOpration();
        }

        public static Iwriter GetInstanceWriter()
        {

            return new PDFOpration();
        }

    }

    class MainClass
    {
        public static void Main()
        {
            IReader pDF = Instance.GetInstanceReader();
            pDF.Read();

            //MSwordOpration mSword = new MSwordOpration();
            //mSword.Read();
            Console.ReadLine();
        }

    }
}
