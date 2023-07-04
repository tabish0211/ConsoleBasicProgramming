using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    class BankDemo
    {
        private int _amount;
        private int _customerId;
        //to intialize object data
        public BankDemo(int customerId, int amount)
        {
            _customerId = customerId;
            _amount = amount;
        }

        public void ShowAccount()
        {

            Console.WriteLine($"Customer Id: {_customerId} and Balance amount is :{_amount}");
        }
    }
}
