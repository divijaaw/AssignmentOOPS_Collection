using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private double basic;
        private string designation;
        public double Basic
        {
            get { return basic; }
            set
            {
                if (value < 5000)
                {
                    throw new LowBasicException("Basic below 5000.");
                }
                basic = value;
            }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public ConfirmEmployee(double basic, string designation, string name, string address) : base(name, address)
        {
            this.Basic = basic;
            this.designation = designation;
        }
        double netSalary;
        public sealed override double CalculateSalary()
        {
            double HRA, conv, PF;
            //,netSalary;
            if (basic >= 30000)
            {
                HRA = 0.3 * basic;
                conv = 0.3 * basic;
                PF = 0.1 * basic;
            }
            else if (basic >= 20000)
            {
                HRA = 0.2 * basic;
                conv = 0.2 * basic;
                PF = 0.1 * basic;
            }
            else
            {
                HRA = 0.1 * basic;
                conv = 0.1 * basic;
                PF = 0.1 * basic;
            }
            netSalary = basic + HRA + conv - PF;
            return netSalary;
        }
        public override string ToString()
        {
            return $"Name is {Name} , Salary:{netSalary}, Employee no:{EmployeeNo}";
        }
    }
}