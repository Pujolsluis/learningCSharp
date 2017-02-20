using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Six_Assignment
{
    class Student : Person
    {
        int studentID { get; set; }

        void TakeTest()
        {
            char score = 'A';
            Console.WriteLine("You got an " + score);
        }
        void SolveAProblem()
        {
            Console.WriteLine("You have solved the assignment");
        }
    }

}
