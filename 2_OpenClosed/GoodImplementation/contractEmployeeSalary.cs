using System;
using System.Collections.Generic;
using System.Text;

namespace _2_OpenClosed.GoodImplementation
{
    public class contractEmployeeSalary : IEmployeeSalary
    {
        public double calculateSalary(Employee employee, int day)
        {
            return employee.dailyWages * day;
        }
    }
}
