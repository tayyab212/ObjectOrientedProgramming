using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    //Class Inside class is nesting class
    // only meaning to that class then nesting
    //For legical grouping the classes
    //connot access instace of outer classes directly but can pass
    //can put any access modifier in nesting class
   public class CustomerNestingClass
    {
        public int TotalBill { get; set; }
        private class CustomerEligible
        {
            public bool IsEligible(CustomerNestingClass c)
            {
                if(c.TotalBill > 100)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
