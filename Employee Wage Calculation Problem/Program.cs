using System;

namespace Employee_Wage_Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage problem!");

            Random rand = new Random();

           

            int is_attended = rand.Next(0, 2);

            const int attended = 1;
            const int wage_per_hour = 20;

            Employee e1 = new Employee(1, "Sai");


            if (is_attended == attended)
            {
                Console.Out.WriteLine("Employee is present");

                int hours = rand.Next(0, 9);

                int wage = e1.CalculateWage(hours, wage_per_hour);

                Console.Out.WriteLine("Employee's wage of the day is " + wage);
            }
            else
            {
                Console.Out.WriteLine("Employee is absent");
            }

            


        }
    }
}
