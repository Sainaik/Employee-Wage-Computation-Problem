using System;

namespace Employee_Wage_Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int MONTHLY_DAYS = 20; 
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


            total_wage = hours * wage * MONTHLY_DAYS;


            Console.Out.WriteLine(total_wage);
        }
    }
}
