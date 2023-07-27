using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicProgramming
{
    //Open closed Principle---If you want to modify you have touch the class
    class Business_Clothing
    {
        public void Cancell() { }
        public int OrderId { get; set; }

        public int StoreId { get; set; }
        public int CouponId { get; set; }

        public int WareHouseId { get; set; }

        public void Save() { }

        public void Validate() { }
    }


    //
   abstract class Order {
        public void Cancell() {

            Console.WriteLine("Order cancelled");
        }


        //Polymorphism--Method overriding--
        public virtual void Save() { }

        public abstract void Validate();
        public int OrderId { get; set; }

    }

    class WareHOuse : Order
    {
        public int WareHouseId { get; set; }

        public override void Save() { }

        public override void Validate() { }

    }
    

    class EcommerceOrder : Order
    {
        public int CouponId { get; set; }

        public override void Save() { }

        public override void Validate() { }

    }

    class StoreOrder : Order
    {
        public int StoreId { get; set; }

        public override void Save() {
        
            //
        }

        public override void Validate() {
        
        //
        
        }

    }

    class OrderProcessor
    {


        //A base class reference can point derive class object
        //public static void Main()
        //{

        //    //Polymorphism --one interface behave diffrently in a different situation
        //    Order storeOrder = new StoreOrder();
        //    storeOrder.Save();
        //    storeOrder.Validate();
        //    storeOrder.Cancell();


        //    Order wareHOuse = new WareHOuse();
        //    wareHOuse.Save();
        //    wareHOuse.Validate();
        //    wareHOuse.Cancell();


        //}
    }
    
}
