using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Five_Assignment
{
    class Degree
    {
        public string mDegreeName { get; set; }
        public int mCreditsRequired { get; set; }
        public Course mCourse { get; set; }

        public Degree(string name, int creditsRequired, Course course)
        {
            mDegreeName = name;
            mCreditsRequired = creditsRequired;
            mCourse = course;
        }
    }
}
