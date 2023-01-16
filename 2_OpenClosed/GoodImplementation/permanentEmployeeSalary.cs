using System;
using System.Collections.Generic;
using System.Text;

namespace _2_OpenClosed.GoodImplementation
{
    public class permanentEmployeeSalary : IEmployeeSalary
    {
        public double bonus { get; set; }
        public double calculateSalary(Employee employee, int day)
        {
            return (employee.dailyWages * day) + bonus;
        }
    }
}
