using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
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
    public class CustomerShadowing
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual decimal TotalBill { get; set; }
        public virtual decimal CalculateDiscount()
        {
            return 0;
        }
    }

    public class DiscountedCustomer : CustomerShadowing
    {
        public string DiscountedCustomerName { get; set; }

        public override decimal CalculateDiscount()
        {
            return TotalBill - 2;
        }
    }
    public class Enquiry :CustomerShadowing
    {
        // By adding new keyword , we can hide this method to parent class during polymorphish
        //go to program.cs class and search shadowing
        public new decimal CalculateDiscount()
        {
            throw new Exception("no discount");
        }
    }
}
