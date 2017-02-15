using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Five_Assignment
{
    class Teacher
    {
        public string mFirstName { get; set; }
        public string mLastName { get; set; }
        public string mAddress1 { get; set; }
        public string mAddress2 { get; set; }
        public string mCountry { get; set; }
        public string mState { get; set; }
        public string mBirthday { get; set; }

        public Teacher(string name, string lastname, string birthday)
        {
            mFirstName = name;
            mLastName = lastname;
            mBirthday = birthday;
        }
    }
}
