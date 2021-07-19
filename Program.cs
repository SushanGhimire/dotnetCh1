using System;

namespace testing
{
    class Student
    {
        private int rollno;
        private double total = 0.0;
        public int Roll
        {
            get { return rollno; }
            set { rollno = value; }
        }
        private int[] marks = new int[3]; //array declaration of length 3
        public int this[int index] // targeting the index of array
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }
        public double Percentage()
        {

            foreach (int i in marks)
            {
                total = total + i; //adding the array numbers
            }
            return total / marks.Length; //returning the percentage
        }
        public string statusCheck()
        {
            // checking  the student  whose % is less than 40 are fail and greater than 40 are pass
            return total / marks.Length < 40 ? "Fail" : "Pass"; //shortcut using ternary operator

            //or you can also do

            // if (total / marks.Length < 40)
            //     return "Fail";
            // else
            //     return "Pass";


        }
    }
    class run
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1[0] = 80;
            s1[1] = 70;
            s1[2] = 50;
            Console.WriteLine("Percentage of Roll no {0} is {1}% and {2}", s1.Roll = 1, s1.Percentage(), s1.statusCheck());
            Student s2 = new Student();
            s2[0] = 30;
            s2[1] = 40;
            s2[2] = 30;
            Console.WriteLine("Percentage of Roll no {0} is {1}% and {2}", s2.Roll = 2, s2.Percentage(), s2.statusCheck());

        }
    }
}
