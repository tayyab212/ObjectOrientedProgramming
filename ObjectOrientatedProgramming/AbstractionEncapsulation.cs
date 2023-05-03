using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    public class Employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public void Validate()
        {
            //Encapsulation : 
            CheckName();
            CheckAddress();
        }

        //Encapsulation
        //Hide complexity to instance
        private void CheckName()
        {

        }
        private void CheckAddress()
        {

        }
    }
}
