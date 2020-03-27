using System;
namespace IT1050Project3
{
    public class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string courseName)
        {
            Name = name; 
            CourseName = courseName;
        }

        public void SetStudentGrade(Student studentName, int studentGrade)
        {
            studentName.Grade += studentGrade;
        }

        public string Print => Name + " teaches " + CourseName;
    }
}

