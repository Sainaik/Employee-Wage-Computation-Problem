﻿using System;

namespace Employee_Wage_Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            // contants
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            int wage = 20;

            //variable
            int type = rand.Next(0, 3);
            int hours = 0;
            int total_wage = 0;

            switch (type)
            {
                case IS_FULL_TIME:
                    hours = 8;
                    break;
                case IS_PART_TIME:
                    hours = 4;
                    break;
                default:
                    hours = 0;
                    break;
            }


            total_wage = hours * wage;


            Console.Out.WriteLine(total_wage);
        }
    }
}
