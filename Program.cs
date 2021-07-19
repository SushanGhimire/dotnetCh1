using System;

namespace testing
{
    class TestingClass
    {
        int id;
        string name;
        TestingClass(int passedId, string passedName)
        {
            this.id = passedId; // here we catch the value from passedId and set it to id;
            this.name = passedName; //// here we catch the value from passedname and set it to name;
        }

        static void Main()
        {
            TestingClass t = new TestingClass(10, "LICT");
            Console.WriteLine("Id of {0} is {1}", t.name, t.id);
            Console.ReadKey();
            // this is the example of parameterized constructor where we have passed the valaue for id and name
            // when we create object it acutomatically invoke the constructor TestingClass() with passed value
        }
    }

}
