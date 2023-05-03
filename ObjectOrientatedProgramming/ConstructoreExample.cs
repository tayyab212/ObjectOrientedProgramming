using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientatedProgramming
{
    // Normal Constructor : Parent to Child
    //a special method of class which gets automatically invoked
    // whenever an instace of a class is created.
    //  First child initializer
    //second child Parent Initializer
    // third parent constructor
    //fourth child constructor

    //Static constructor  : Child to Parent
    //fire when you access class first time
    //first child static constructor runs
    //second parent static constructor runs
    public class Human
    {
        public int i = 0;
        public Human()
        {
            Console.WriteLine("Human");
        }
    }
    public class Women : Human
    {
        public int i1 = 0;
        public Women()
        {
            Console.WriteLine("Women");
        }
    }
}
