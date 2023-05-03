using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // overriding: parent child relation must, use virtual keyword
    // Helps us to define some logic in the parent class
    //which can be overridden in the child class
    public class EmployeeVirtual
    {
        public string name { get; set; }
        public string address { get; set; }
        public virtual void Validate()
        {
            //here is some logic in parent class
            CheckName();
            CheckAddress();
        }


        private void CheckName()
        {

        }
        private void CheckAddress()
        {

        }
    }
    public class ManagerVirtual : EmployeeVirtual
    {
        // Now this class inherit all the properties and methods of Employee1 class
        //this class cal also define its own methods and properties
        public override void Validate()
        {
            // our own logic
        }

        //overloading
        //same method names with different signature in the same class
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict,int num1)
        {
            //our own logic
        }
    }
}
