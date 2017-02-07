using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes, variables and Operators
            int myVar = 2;
            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar + secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;

            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(value);
            #endregion
        }
    }
}
