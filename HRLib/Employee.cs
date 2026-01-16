using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public abstract class Employee
    {
        static int cnt = 0;
        private string name;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int employeeNo;
        public int EmployeeNo
        {
            get { return employeeNo; }
            set { employeeNo = value; }
        }
        public Employee(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Employee()
        {
            EmployeeNo = cnt;
            cnt++;
        }
        public abstract double CalculateSalary();
        public override string ToString()
        {
            return $"Name is {name}, Address is {address}, Employee No: {EmployeeNo}";
        }
    }
}