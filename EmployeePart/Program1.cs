﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePart
{
    class Program1
    {
        public static void Main()
        {
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
