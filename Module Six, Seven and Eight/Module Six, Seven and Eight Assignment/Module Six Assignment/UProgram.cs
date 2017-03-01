using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Six_Assignment
{
    class UProgram
    {
        public string mName { get; set; }
        public string mDepartmentHead { get; set; }
        public Degree mDegrees { get; set; }

        public UProgram(string name, string departmentHead, Degree degree)
        {
            mName = name;
            mDepartmentHead = departmentHead;
            mDegrees = degree;
        }
    }
}
