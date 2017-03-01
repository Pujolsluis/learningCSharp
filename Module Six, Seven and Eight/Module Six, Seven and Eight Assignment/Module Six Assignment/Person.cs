using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Six_Assignment
{
    class Person
    {
        public string mFirstName { get; set; }
        public string mLastName { get; set; }
        public string mBirthday { get; set; }
        public string mAddress1 { get; set; }
        public string mAddress2 { get; set; }
        public int mPostalCode { get; set; }
        public string mCountry { get; set; }
        public string mState { get; set; }

        public Person() { }

        public Person(string name, string lastname, string birthday)
        {
            mFirstName = name;
            mLastName = lastname;
            mBirthday = birthday;
        }

        public Person(string name, string lastname, string birthday, string address1, string address2
            , int postalcode, string country, string state)
        {
            mFirstName = name;
            mLastName = lastname;
            mBirthday = birthday;
            mAddress1 = address1;
            mAddress2 = address2;
            mPostalCode = postalcode;
            mCountry = country;
            mState = state;
        }
    }
}
