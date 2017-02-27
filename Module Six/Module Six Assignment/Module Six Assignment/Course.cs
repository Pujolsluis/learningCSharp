using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module_Six_Assignment
{
    class Course
    {
        public string mName { get; set; }
        public Teacher[] mTeacher { get; set; }
        public ArrayList mStudents { get; set; }
        public int mCredits { get; set; }
        public int mRequiredCredits { get; set; }

        public Course(string name, Teacher[] teachers, int credits, int requiredCredits, ArrayList students)
        {
            mName = name;
            mTeacher = teachers;
            mCredits = credits;
            mRequiredCredits = requiredCredits;
            mStudents = students;
        }

        public void ListStudents()
        {
            foreach (Student student in mStudents)
            {
                Console.WriteLine("Student Name: {0} {1}", student.mFirstName, student.mLastName);
            }

        }
    }
}
