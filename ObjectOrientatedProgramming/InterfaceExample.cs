using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // interface cannot have logic
    // by default all methods are public
    //only signature, not implementation
    //interface is a contract,by having contract we have better control on impact analysis,
    // change management and breaking changes
    //can't create an instance of interface

    //Multiple inheritance helps to add new methods with out affecting the old interface

    //Interface seggregation principle
    // don't force client to use unnecessary methods
    // create new interface and do multiple inheritence
    public interface ICustomer
    {
        string name { get; set; }
        string address { get; set; }
        string productName { get; set; }
        decimal productAmount { get; set; }

        decimal CalculateDiscount();


    }

    // if a one new method is required in second class create new
    //interface and do multiple inheritence
    public interface ICustomerWithInterest : ICustomer
    {
        decimal CalculateInterest();

    }

    public abstract class CustomerInterface: ICustomer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public abstract decimal CalculateDiscount();
    }

    public abstract class CustomerMultiInterface : ICustomerWithInterest
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public abstract decimal CalculateDiscount();

        //interface seggregation principle
        public abstract decimal CalculateInterest();

    }

}
