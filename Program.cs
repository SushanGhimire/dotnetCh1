using System;
namespace testing
{
    class Parent
    {
        //keyword "virtual" written in method means it is going to override in the child class
        public virtual void display()
        {
            System.Console.WriteLine("I am from Parent");
        }
    }
    class Child : Parent
    {
        public override void display()
        {
            System.Console.WriteLine("I am from Child");
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.display();
        }

    }
}
