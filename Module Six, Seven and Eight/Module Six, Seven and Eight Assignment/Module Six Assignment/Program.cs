﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module_Six_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Luis", "Pujols", "19 july 1995");
            student1.AddGrade("A");
            student1.AddGrade("A");
            student1.AddGrade("A");
            student1.AddGrade("B");
            student1.AddGrade("B+");
            Student student2 = new Student("Maria", "Polanco", "1 january 1990");
            student1.AddGrade("A");
            student1.AddGrade("B");
            student1.AddGrade("A");
            student1.AddGrade("B");
            student1.AddGrade("B+");
            Student student3 = new Student("Pedro", "Gonzales", "5 August 1985");
            student1.AddGrade("B");
            student1.AddGrade("A");
            student1.AddGrade("C");
            student1.AddGrade("B");
            student1.AddGrade("B+");
            Teacher teacher1 = new Teacher("Francia", "Martinez", "2 March 1975");
            Teacher teacher2 = new Teacher("Roberto", "Campusano", "15 December 1964");
            Teacher teacher3 = new Teacher("Edward", "Garcia", " 22 November 1968");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Teacher[] teachers = { teacher1, teacher2, teacher3 };
            Course course = new Course("Programming with C#", teachers, 4, 180, students);
            Degree degree = new Degree("Bachelor of Science", 256, course);
            UProgram uprogram = new UProgram("Information Technology", "Martin Guzman", degree);

            Console.WriteLine("The {0} program contains the {1} degree\n", uprogram.mName, uprogram.mDegrees.mDegreeName);
            Console.WriteLine("The {0} degree contains the {1} course\n", uprogram.mDegrees.mDegreeName, uprogram.mDegrees.mCourse.mName);
            Console.WriteLine("The {0} course contains {1} student(s)\n", uprogram.mDegrees.mCourse.mName, Student.mStudentCount);
            course.ListStudents();
        }
    }
}
