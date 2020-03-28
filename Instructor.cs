using System;
namespace IT1050Project3
{
    public class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.Grade += Grade;
        }

        public void Print()
        {
            System.Console.Write("Professor " + this.Name);
            System.Console.Write(" teaches " + this.CourseName);
        }
    }
}

