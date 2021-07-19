using System;
using System.Linq;
using System.Collections.Generic;
namespace testing
{
    class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)
        {
            //declearing  the array
            List<Student> sutdentList = new List<Student>()
            {
                new Student (){
                    Id=1,name="A", age=12
                },
                 new Student (){
                    Id=2,name="B", age=20
                },
                 new Student (){
                    Id=3,name="C", age=17
                },
                 new Student (){
                    Id=4,name="D", age=22
                },
            };
            var teenager = from s in sutdentList
                           where s.age > 12 && s.age < 18
                           select s;
            var adult = from s in sutdentList
                        where s.age > 18
                        select s;
            System.Console.WriteLine("Teenagers");
            foreach (var n in teenager)
                System.Console.WriteLine("Age of {0} is {1}", n.name, n.age);
            System.Console.WriteLine("Adults");
            foreach (var n in adult)
                System.Console.WriteLine("Age of {0} is {1}", n.name, n.age);
        }

    }
}
