using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class BankDemo
    {
        private int _amount;//100+200--300
        private int _customerId;//2001

        //to intialize object data


        //constructor overloading
        public BankDemo()
        {
            _customerId = 1001;
            _amount = 100;

        }
        public BankDemo(int customerId)
        {
            _customerId = customerId;
            
        }

        public BankDemo(int customerId, int amount):this(customerId)
        {
           // _customerId = customerId;
            _amount = amount;
        }

        //method overloading
        public void Sum()
        {
            Console.WriteLine("no param in sum");
        }

        public void Sum(int x, int y)
        {
            Console.WriteLine("sum with 2 parameters");
        }

        public void ShowAccount()
        {

            Console.WriteLine($"Customer Id: {_customerId} and Balance amount is :{_amount}");
        }


        //public void SetAmount(int amount)
        //{

        //    _amount =  _amount+amount;
        //}

        //public int GetAmount()
        //{

        //    return _amount;
        //}

        //public int GetCustomerId()
        //{

        //    return _customerId;
        //}


        //Property is nothing but getter setter

        //2.0
        //public int Amount
        //{
        //    get { return _amount; }
        //    set { _amount = value; }
        //}

        //public int CustomerId
        //{
        //    get { return _customerId; }
        //    set { _customerId = value; }
        //}

        public int Amount { get; set; }
        public int CustomerId { get; set; }
    }
}
