using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // Main goal of SOLID is to minimize dependencies.Making code understand,maintain and extend
    // imporve quality of code
    //Singleresponsibility: A class should have one and only purpose
    // OpenClodedPrinciple: Opened for extension and cloded for modification
    //Reduce Impact changes as you are now making changes n the inherited classes

    // IN LISKOV and ISP : we broke classes and Interface respectively
    //LISKOV substitution principe ://Child methods/properties/functions/etc are will be hidden from the parent during polymorphish
    //resolve by changing parent class
    //LISKOV is more related to inheritence where we have grouped class in a wrong family
    //due to which child class is forced to implement methods which it should not

    //Interface seggregation : No code should be forced to depends on methods/properties which is not 
    //concerned with them
    // multi inheritence 

    //Dependency Inversion Principle: Higher level modules should not depend on lower level
    //modules via abstraction
    //Module which calls the other module is termed as Higher level module
    //The module which gets consumed is termed as Lower Level module.
    //Caller : High level module
    //Callee : Low Level module
    //if there is a change in callee(lower module) we have to change caller
    public class SingleResponsibility
    {
        public string name { get; set; }
        public int amount { get; set; }
        public string address { get; set; }

        //Customer class should not have discount methods , this is someone
        //else responsibility , create new class Discount and implement methods there
        //public int CalculateDiscount()
        //{
        //    return 0;
        //}
    }
    public class Discount
    {
        public virtual int CalculateDiscount(SingleResponsibility c)
        {
            if (c.amount > 100)
            {
                return c.amount - 2;
            }
            return c.amount;
        }
    }

    // Open for extension, we added a new class and override the above method
    public class DiscountIslamabad : Discount
    {
        public override int CalculateDiscount(SingleResponsibility c)
        {
            int finalAmount = c.amount;
            if (c.address.Contains("islamabad"))
            {
                finalAmount = c.amount - 3;
            }
            return finalAmount;
        }
    }




    //Child methods/properties/functions/etc are will be hidden from the parent during polymorphish
    //by add new keywords
    //in override polymorphism is followed parent objet will invoke child methods which are overriden.
    //while in case of shadowing the parent object will not see/invoke
    //the shadowed methods during polymorphism

    //shadowing is a hack which developer implement when the child classes do not
    //implement all the methods of the parent.
    //this is also termed as LISKOV problem and it happends due to wrong abstraction.
    //LISKOV problem: when child class does not behave like parent class
    //dont implement all the parent class methods
    //To Resolve LISKOV create a new base class 
    //Inversion of control: we invert object creation control outside the higher module.
    //Dependency injection: Pass dependent object from outside
    public class LISKOVBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual decimal TotalBill { get; set; }
    }
    public class LISKOV : LISKOVBase
    {
        //public string Name { get; set; }
        //public string Address { get; set; }
        //public virtual decimal TotalBill { get; set; }
        public virtual decimal CalculateDiscount()
        {
            return 0;
        }
    }

    public class DiscountedCustomerLISKOV : LISKOV
    {
        public string DiscountedCustomerName { get; set; }

        public override decimal CalculateDiscount()
        {
            return TotalBill - 2;
        }
    }
    public class EnquiryLISKOV : LISKOVBase
    {
        // By adding new keyword , we can hide this method to parent class during polymorphish
        //go to program.cs class and search shadowing
        //public new decimal CalculateDiscount()
        //{
        //    throw new Exception("no discount");
        //}
    }


    //DependencyInversion

    public class CustomerCaller
    {
     
        public decimal Amount { get; set; }
        private IDiscount _dis = null;
        public CustomerCaller(IDiscount dis)
        {
            _dis = dis;
        }
        public virtual decimal CalculateDiscount()
        {
            return _dis.CalculateDiscount();
        }
    }

    public class DiscountA : IDiscount
    {
        public decimal CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }


    public interface IDiscount
    {
        decimal CalculateDiscount();
    }
}
