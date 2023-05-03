using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // cannot be inherited any further
    //can create an instace of class
    public class A
    {

    }
    public sealed class B : A
    {

    }

    // below code will give compile time error 
    //public class C : B
    //{

    //}

}
