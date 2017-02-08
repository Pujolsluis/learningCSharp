using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_One_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int id, zipPostalCode;
            string birthday;
            string addressLine1, addressLine2;
            string city, stateProvince, country;

            Console.WriteLine("Student First Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Student Last Name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Student ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student birthday:");
            birthday = Console.ReadLine();
            Console.WriteLine("Student Address 1:");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Student Address 2:");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Student city:");
            city = Console.ReadLine();
            Console.WriteLine("Student State/Province:");
            stateProvince = Console.ReadLine();
            Console.WriteLine("Student ZIP/Postal Code:");
            zipPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Country:");
            country = Console.ReadLine();

           
        }
    }
}
