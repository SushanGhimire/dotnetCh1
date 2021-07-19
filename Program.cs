﻿using System;

namespace testing
{
    public class Parent
    {
        public string name = "LICT";
        public Parent()
        {
            System.Console.WriteLine(" i am from Parent Constructor");
        }
        public void display()
        {
            System.Console.WriteLine("I am from Parent Class");
        }
    }
    public class Child : Parent
    {
        public Child() : base()
        {
            System.Console.WriteLine("I am from child constructor");
            System.Console.WriteLine(base.name);
            base.display();
            //here using base keyword we can access the all public methods of parent class
            //base keyword is used in sub class therefore before using base keyword super class should be made firt
            // here Parent is super class and child is sub class
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            // c.display();
            Console.ReadKey();

            //since it is a example of inheritance we can access display method from here also
        }
    }
}
