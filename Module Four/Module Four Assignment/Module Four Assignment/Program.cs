using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Four_Assignment
{
    class Program
    {
        public struct Student{
            public string mFirstName { get; set; }
            public string mLastName { get; set; }
            public string mAddress1 { get; set; }
            public string mAddress2 { get; set; }
            public string mCountry { get; set; }
            public string mState { get; set; }
            public string mBirthday { get; set; }

            Student(string name, string lastName, string address1, string address2, string country, string state, string birthday)
            {
                this.mFirstName = name;
                this.mLastName = lastName;
                this.mAddress1 = address1;
                this.mAddress2 = address2;
                this.mCountry = country;
                this.mState = state;
                this.mBirthday = birthday;
            }

        }

        public struct Teacher
        {
            public string mFirstName { get; set; }
            public string mLastName { get; set; }
            public string mAddress1 { get; set; }
            public string mAddress2 { get; set; }
            public string mCountry { get; set; }
            public string mState { get; set; }
            public string mBirthday { get; set; }

            Teacher(string name, string lastName, string address1, string address2, string country, string state, string birthday)
            {
                this.mFirstName = name;
                this.mLastName = lastName;
                this.mAddress1 = address1;
                this.mAddress2 = address2;
                this.mCountry = country;
                this.mState = state;
                this.mBirthday = birthday;
            }

        }

        public struct UProgram
        {
            public string mName { get; set; }
            public string mDepartmentHead { get; set; }
            public string mDegrees { get; set; }
            

            UProgram(string name, string departmentHead, string degrees)
            {
                this.mName = name;
                this.mDepartmentHead = departmentHead;
                this.mDegrees = degrees;

            }

        }

        public struct Course
        {
            public string mName { get; set; }
            public string mTeacher { get; set; }
            public int mCredits { get; set; }
            public int mRequiredCredits { get; set; }
           

            Course(string name, string teacher, int credits, int requiredCredits)
            {
                this.mName = name;
                this.mTeacher = teacher;
                this.mCredits = credits;
                this.mRequiredCredits = requiredCredits;

            }

        }

        static void Main(string[] args)
        {
            Student[] studentArray = new Student[5];
            studentArray[0].mFirstName = "Luis";
            studentArray[0].mLastName = "Pujols";
            studentArray[0].mAddress1 = "Alma rosa I";
            studentArray[0].mAddress2 = "Santo Domingo ESTE";
            studentArray[0].mCountry = "Dominican Republic";
            studentArray[0].mState = "Distrito Nacional";
            studentArray[0].mBirthday = "19 july 1995";

            Console.WriteLine("Student Information:\nFirst Name: {0}\nLast Name: {1}\nAddress 1: {2}\nAddress 2: {3}\nCountry: {4}\nState: {5}\nBirthday: {6}"
                , studentArray[0].mFirstName, studentArray[0].mLastName, studentArray[0].mAddress1, studentArray[0].mAddress2, studentArray[0].mCountry,
                  studentArray[0].mState, studentArray[0].mBirthday);
        }
    }
}
