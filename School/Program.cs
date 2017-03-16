using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        public class Student
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int studentId;
            public int StudentId
            {
                get { return studentId; }
                internal set { studentId = value; }
            }
            private int numberOfCredits = 0;
            private double gpa = 0;
        }
        public class Course
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int courseNumber;
            public int CourseNumber
            {
                get { return courseNumber; }
                internal set { courseNumber = value; }
            }
            private List<Student> students;
        }
        static void Main(string[] args)
        {
        }
    }
}
