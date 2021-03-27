using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
    public class Calculator
    {
        public static void init()
        {
            Console.WriteLine("Enter the operation u want to perform");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Commands.add();
                    break;
                case "-":
                    Commands.sub();
                    break;
                case "*":
                    Commands.mul();
                    break;
                case "/":
                    Commands.div();
                    break;
                default:
                    Console.WriteLine("Invalid OPeration");
                    break;
              
            }

        }

    }
}
