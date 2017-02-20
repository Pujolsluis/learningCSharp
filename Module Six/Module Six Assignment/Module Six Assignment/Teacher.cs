using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Six_Assignment
{
    class Teacher : Person
    {
        public Teacher(string name, string lastname, string birthday) : base(name, lastname, birthday)
        {
        }

        int employeeID { get; set; }

        void GradeTest()
        {
            Console.WriteLine("Your student test has been graded");
        }

        void TakeAssistance()
        {
            Console.WriteLine("All of your students are present");
        }
    }
}
