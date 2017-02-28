using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Six_Assignment
{
    class Student : Person
    {
        int studentID { get; set; }
        Stack<string> Grades { get; set; }
        public static int mStudentCount = 0;
        

        public Student(string name, string lastname, string birthday) : base(name, lastname, birthday)
        {
            mStudentCount++;
            Grades = new Stack<string>();
        }

        public void TakeTest()
        {
            char score = 'A';
            Console.WriteLine("You got an " + score);
        }
        public void SolveAProblem()
        {
            Console.WriteLine("You have solved the assignment");
        }

        public void AddGrade(string grade)
        {
            Grades.Push(grade);
        }

        public void RemoveGrade()
        {
            if (Grades.Count > 0) Grades.Pop();
        }
    }

}
