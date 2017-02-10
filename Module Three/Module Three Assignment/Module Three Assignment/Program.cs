using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Three_Assignment
{
    class Program
    {
        static string studentFirstName, studentLastName, studentAddress1, studentAddress2, studentCountry, studentState;
        static int studentZipCode;
        static string studentBirthday;
        static string teacherFirstName, teacherLastName, teacherAddress1, teacherAddress2, teacherCountry, teacherState;
        static int teacherZipCode;
        static string teacherBirthday;
        static string uProgramName, uProgramDepartmentHead, uProgramDegrees;
        static string degreeName;
        static int degreeCreditsRequired;
        static string courseName, courseTeacher;
        static int courseCredits, courseDurationInWeeks;

        static void Main(string[] args)
        {
            getStudent();
            getTeacher();
            getUProgram();
            getDegree();
            getCourse();
            printStudent(studentFirstName, studentLastName, studentAddress1, studentAddress2, studentCountry, studentState, studentZipCode, studentBirthday);
            printTeacher(teacherFirstName, teacherLastName, teacherAddress1, teacherAddress2, teacherCountry, teacherState, teacherZipCode, teacherBirthday);
            printUProgram(uProgramName, uProgramDepartmentHead, uProgramDegrees);
            printDegree(degreeName, Convert.ToString(degreeCreditsRequired));
            printCourse(courseName, courseCredits.ToString(), courseDurationInWeeks.ToString());
        }

        public static void getStudent()
        {
            Console.WriteLine("Student First Name:");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("Student Last Name:");
            studentLastName = Console.ReadLine();
            Console.WriteLine("Student Address 1:");
            studentAddress1 = Console.ReadLine();
            Console.WriteLine("Student Address 2:");
            studentAddress2 = Console.ReadLine();
            Console.WriteLine("Student Zipcode:");
            studentZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Student State:");
            studentState = Console.ReadLine();
            Console.WriteLine("Student Country:");
            studentCountry = Console.ReadLine();
            Console.WriteLine("Student Birthday:");
            studentBirthday = Console.ReadLine();
        }

        public static void getTeacher()
        {
            Console.WriteLine("Teacher First Name:");
            teacherFirstName = Console.ReadLine();
            Console.WriteLine("Teacher Last Name:");
            teacherLastName = Console.ReadLine();
            Console.WriteLine("Teacher Address 1:");
            teacherAddress1 = Console.ReadLine();
            Console.WriteLine("Teacher Address 2:");
            teacherAddress2 = Console.ReadLine();
            Console.WriteLine("Teacher Zipcode:");
            teacherZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Teacher State:");
            teacherState = Console.ReadLine();
            Console.WriteLine("Teacher Country:");
            teacherCountry = Console.ReadLine();
            Console.WriteLine("Teacher Birthday:");
            teacherBirthday = Console.ReadLine();
        }

        public static void getUProgram()
        {
            Console.WriteLine("UProgram Name:");
            uProgramName = Console.ReadLine();
            Console.WriteLine("UProgram Department Head:");
            uProgramDepartmentHead = Console.ReadLine();
            Console.WriteLine("UProgram Degrees:");
            uProgramDegrees = Console.ReadLine();
        }

        public static void getDegree()
        {
            Console.WriteLine("Degree Name:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Degree Credits Required:");
            degreeCreditsRequired = int.Parse(Console.ReadLine());
        }

        public static  void getCourse()
        {
            Console.WriteLine("Course Name:");
            courseName = Console.ReadLine();
            Console.WriteLine("Course Credits:");
            courseCredits = int.Parse(Console.ReadLine());
            Console.WriteLine("Course Duration In Weeks:");
            courseDurationInWeeks = int.Parse(Console.ReadLine());
            Console.WriteLine("Course Teacher:");
            courseTeacher = Console.ReadLine();
        }

        public static void printStudent(string firstName, string lastName, string address1, string address2, string country, string state, int zipCode, string birthday)
        {
            Console.WriteLine("Student Information:\nName: {0}\nAddress 1: {1}\nAddress 2: {2}\nCountry: {3}\nState: {4}\nZipCode: {5}\nBirthday: {6}",
                firstName + " " + lastName, address1, address2, country, state, zipCode, birthday.ToString());
        }

        public static void printTeacher(string firstName, string lastName, string address1, string address2, string country, string state, int zipCode, string birthday)
        {
            Console.WriteLine("Teacher Information:\nName: {0}\nAddress 1: {1}\nAddress 2: {2}\nCountry: {3}\nState: {4}\nZipCode: {5}\nBirthday: {6}",
                firstName + " " + lastName, address1, address2, country, state, zipCode, birthday.ToString());
        }

        public static void printUProgram(string name, string departmentHead, string degrees)
        {
            Console.WriteLine("Uprogram Information:\nName: {0}\nDepartment Head: {1}\nDegrees: {2}", name, departmentHead, degrees);
        }

        public static void printDegree(string name, string creditsRequired)
        {
            Console.WriteLine("Degree Information:\nName: {0}\nCredits Required: {1}", name, creditsRequired);
        }

        public static void printCourse(string name, string credits, string courseDuration)
        {
            Console.WriteLine("Course Information:\nName: {0}\nCredits: {1}\nCourse Duration In Weeks: {2}",
                name, credits, courseDuration);
        }
    }
}
