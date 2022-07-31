﻿using System;

namespace uc1
{
    class Program
    {

        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;

        static void Main(string[] args)
        {


            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case Is_Part_Time:
                    empHour = 4;
                    break;
                case Is_Full_Time:
                    empHour = 8;
                    break;
                default:
                    empHour = 0;
                    break;
            }
            empWage = empHour * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}
