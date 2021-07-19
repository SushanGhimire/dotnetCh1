using System;

namespace testing
{
    class ClassProperty
    {
        private int num1;
        private int num2;

        public int setNum1
        {
            get { return num1; } //gettting variable from above
            set { num1 = value; } //setting the value to the variable
        }
        public int setNum2
        {
            get { return num2; }  //gettting variable from above
            set { num2 = value; } //setting the value to the variable
        }
        public void display()
        {
            Console.WriteLine("Numbers are {0} and {1} ", num1, num2);
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            ClassProperty c = new ClassProperty();
            c.setNum1 = 10;
            c.setNum2 = 20;
            c.display();
        }
    }

}
