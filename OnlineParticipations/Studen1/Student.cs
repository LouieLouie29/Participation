//Ed Louie9=
using System;
using System.Collections.Generic;
using System.Text;

namespace Studen1
{
    class Student
    {
        double GPA;
        double GPAVal;
        double Hours;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> CourseNames { get; set; }

        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            CourseNames = CourseNames;
            CourseGrades = CourseGrades;
        }

        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
        }

        public double GPACalc()
        {
            double GPA = (GPAVal * Hours) / Hours;

            return GPA;
        }      

    }
}
