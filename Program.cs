using System;

namespace testing
{
    public class ParentClass
    {
        public void print()
        {
            Console.WriteLine("I am from Parent Class");
        }

    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("I am from child Constructor");
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.print();

            //here we extend the parent class from child class. since he have inheritd the parent class so we can access the parent methods from childclass object.

            // here when we create the childclass object it automatically invoke the childclass contructor and we access the print method of parent class from childClass object
        }
    }

}
