using System;

namespace Employee_Wage_Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage problem!");

            Random rand = new Random();

            Employee e1 = new Employee(1,"Sai");

            int is_attended = rand.Next(0, 2);

            int attended = 1;


            if(is_attended == attended)
            {
                Console.Out.WriteLine("Employee is present");
            }
            else
            {
                Console.Out.WriteLine("Employee is absent");
            }
        }
    }
}
