using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Calculation_Problem
{

    class ParttimeEmployee:Employee
    {
        const int parttime_hours = 8;
        public ParttimeEmployee(int id,String name):base(id,name)
        {
        }

    }
}
