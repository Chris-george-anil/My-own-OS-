using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
    public class Commands
    {
        public static void SayHello()
        {
            Console.Write("Hello User Welcome to our OS");
        }
        public static void add()
        {
            Console.Write("Enter the First Number:  ");
            uint first=Utilities.ReadNum(0,10000000);
            Console.Write("Enter the second number:  ");
            uint second = Utilities.ReadNum(0,1000000);
            Console.WriteLine("The sum of the 2 numbers is  " + (first + second));
;        }
        public static void sub()
        {
            Console.Write("Enter the First Number:  ");
            uint first = Utilities.ReadNum(0, 10000000);
            Console.Write("Enter the second number:  ");
            uint second = Utilities.ReadNum(0, 1000000);
            Console.WriteLine("The Difference between the 2 numbers is  " + (first - second));
        }
        public static void mul()
        {
            Console.Write("Enter the First Number:  ");
            uint first = Utilities.ReadNum(0, 10000000);
            Console.Write("Enter the second number:  ");
            uint second = Utilities.ReadNum(0, 1000000);
            Console.WriteLine("The product of the 2 numbers is  " + (first * second));
        }
        public static void div()
        {
            Console.Write("Enter the First Number:  ");
            uint first = Utilities.ReadNum(0, 10000000);
            Console.Write("Enter the second number:  ");
            uint second = Utilities.ReadNum(0, 1000000);
            Console.WriteLine("The Difference between the 2 numbers is  " + (first / second));
        }
        public static void time()
        {
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
        }
    }
}
