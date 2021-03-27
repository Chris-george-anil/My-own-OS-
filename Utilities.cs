using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
   public class Utilities
    {
        public static uint ReadNum(uint start,uint end,uint otherwise = 0)
        {
            uint a;
            String UserInput = Console.ReadLine();
            for (a = start; a <= end; a++)
            {
                if (a.ToString() == UserInput)
                {
                    return a;
                }
            }
            return otherwise;
        }
    }
}
