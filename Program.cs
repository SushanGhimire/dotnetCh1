using System;
namespace testing
{
    class Parent
    {
        // Encapsulation is implemented by using access specifiers.
        //access specifiers are
        //public,private,protected,internal, protected Internal
        public int area = 20; // accessable from entire program
        private int length; //accessable only from Parent Class

        public void display(int a)
        {
            this.length = a;
            System.Console.WriteLine(length);
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.display(10);
            System.Console.WriteLine(p.area);
        }

    }
}
