﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Five_Assignment
{
    class Course
    {
        public string mName { get; set; }
        public Teacher[] mTeacher { get; set; }
        public Student[] mStudents { get; set; }
        public int mCredits { get; set; }
        public int mRequiredCredits { get; set; }

        public Course(string name, Teacher[] teachers, int credits, int requiredCredits, Student[] students)
        {
            mName = name;
            mTeacher = teachers;
            mCredits = credits;
            mRequiredCredits = requiredCredits;
            mStudents = students;
        }

    }
}
