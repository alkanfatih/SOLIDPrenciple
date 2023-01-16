using System;
using System.Collections.Generic;
using System.Text;

namespace _2_OpenClosed.BadImplementation
{
    public class EmployeeSalary
    {
        public Double calculateSalary(Employee employee, int day, double bonus) 
        {
            double salary = 0;

            if (employee.EmployeeType == "permanent")
            {
                salary = (employee.dailyWages * day) + bonus;
            }
            else if(employee.EmployeeType == "contract")
            {
                salary = (employee.dailyWages * day);
            }
            return salary;
        }
    }
}
