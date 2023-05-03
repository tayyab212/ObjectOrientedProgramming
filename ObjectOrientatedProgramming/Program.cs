﻿using System;

namespace ObjectOrientatedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            //Encapsulation impplement abstraction
            //Abstraction, only validate method is visible and other methods are hidden
            e1.Validate();

            //Inheritance
            //Manager class has access to all public properties and methods of employee1 class
            //als has access to its own methods
            // Is A relationship , Manager is a child of Employee1 class
            Manager m1 = new Manager();
            m1.Validate();
            m1.Management();
            Console.WriteLine("Hello World!");

            // Polymorphish
            // different form of an object
            e1 = new Manager();
            e1.Validate();
            e1 = new Supervisor();
            e1.Validate();
        }

    }
}