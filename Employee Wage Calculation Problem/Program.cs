using System;

namespace Employee_Wage_Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int is_full_time = 1;
            int is_part_time = 2;
            int wage = 20;

            //variable
            int type = rand.Next(0, 3);
            int hours = 0;
            int total_wage = 0;

            switch (type)
            {
                case 1:
                    hours = 8;
                    break;
                case 2:
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
