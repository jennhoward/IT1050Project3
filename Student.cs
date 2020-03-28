using System;
namespace IT1050Project3
{
    public class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade += grade;
        }

        public void Print()
        {
            System.Console.Write("Student ");
            System.Console.Write(this.Name);
            System.Console.Write(" has a grade of ");
            System.Console.Write(this.Grade);
            System.Console.Write(" from ");
            Teacher.Print();
            //System.Console.Write(this.Teacher);
        }
    }
}
