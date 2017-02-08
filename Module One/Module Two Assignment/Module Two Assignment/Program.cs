using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Two_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            char initChar = 'X';
            char secondChar = 'O';
            for(int i=1; i<=8; i++)
            {
                if (i % 2 == 0)
                {
                    initChar = 'O';
                    secondChar = 'X';
                }
                else
                {
                    initChar = 'X';
                    secondChar = 'O';
                }
                
                for(int q=1; q<=8; q++)
                {
                    if (q % 2 != 0) Console.Write(initChar);
                    else Console.Write(secondChar);
                }
                Console.Write("\n");
            }
        }
    }
}
