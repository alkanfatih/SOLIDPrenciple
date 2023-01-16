using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.BadImplementation
{
    public class Employee
    {
        private string fullName;
        private string dateOfJoing;
        private string annualSalaryPackage;

        //Standard getters and setters methods

        //Business logic
        public double calculateEmployeeSalary { get; set; }
        public double calculateEmployeeLeaves { get; set; }
        public double calculateTaxOnSalary { get; set; }

        //Data persistence logic
        public void saveEmployee() { }
        public void updateEmployee() { }
    }
}
