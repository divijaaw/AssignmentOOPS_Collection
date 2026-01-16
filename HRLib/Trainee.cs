using System.Xml.Linq;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noOfDays;
        private double rate;
        public int Days
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public Trainee(int noOfDays, double rate, string name, string address) : base(name, address)
        {
            this.noOfDays = noOfDays;
            this.rate = rate;
        }
        public Trainee() { }
        public sealed override double CalculateSalary()
        {
            return noOfDays * rate;
        }
        public override string ToString()
        {
            return $"Name is {Name} , Salary:{noOfDays * rate},Employee No:{EmployeeNo}";
        }

    }
}