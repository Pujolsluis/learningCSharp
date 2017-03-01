using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        public string mFirstName { get; set; }
        public string mLastName { get; set; }
        public string mCity { get; set; }

        public Student(string firstName, string lastName, string city)
        {
            mFirstName = firstName;
            mLastName = lastName;
            mCity = city;
        }
    }
}
