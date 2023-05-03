using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // Abstract Class : Half Defined Parent Class
    // Cannot create an instance of abstract class
    // Abstract method inside abstract class is virtual
    // Abstract methods are compulsary to implement
    // A simple base class can not be defined in a pure half way
   public abstract class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();
       
    }
    public class GoldCustomer :Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }
    }
    public class SilverCustomer :Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }

    }
}
