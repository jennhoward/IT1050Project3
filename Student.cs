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
            Name = name;
            Teacher = teacher;
            Grade = 0;
        }

        public void SetGrade(int grade)
        {
            Grade += grade;
        }

        public string Print()
        {
            return $"{Name} has an " + Grade + " from " + Teacher.Print;
        }
    }
}
