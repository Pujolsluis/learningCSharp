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
            string firstName, lastName, addressLine1, addressLine2, city, state, country;
            DateTime birthdate;
            int zip;

            Console.WriteLine("Type in your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Type in your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Type in your address line 1:");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Type in your address line 2:");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Type in your city:");
            city = Console.ReadLine();
            Console.WriteLine("Type in your state:");
            state = Console.ReadLine();
            Console.WriteLine("Type in your country:");
            country = Console.ReadLine();
            Console.WriteLine("Type in your zipcode:");
            zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your birthdate:");
            birthdate = DateTime.Parse(Console.ReadLine());

            //firstName = "Oliver";
            //lastName = "Velich";
            //addressLine1 = "Křižkovského 12";
            //addressLine2 = "";
            //city = "Brno";
            //state = "South Moravia";
            //country = "Czech Republic";
            //birthdate = new DateTime(1993, 5, 22);
            //zip = 60300;
            Console.WriteLine("Your name is {0} {1}", firstName, lastName);
            Console.WriteLine("Your address is:\n{0}\n{1}\n{2}, {3}\n{4}\n{5}", addressLine1, addressLine2, zip.ToString(), city, state, country);
            Console.WriteLine("Your birthday is on {0:d}", birthdate);
            Console.ReadLine();

        }
    }
}
