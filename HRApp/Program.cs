using HRLib;
namespace HRApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainee emp2 = new Trainee(2, 2000000, "name", "Pune");
            Console.WriteLine("No.of days * rate: " + emp2.CalculateSalary());
            ConfirmEmployee emp3 = new ConfirmEmployee(300000, "B", "DEF", "Pune");
            Console.WriteLine("NET SALARY : " + emp3.CalculateSalary());
            try
            {
                ConfirmEmployee emp = new ConfirmEmployee(1000, "A", "ABC", "Pune");
                Console.WriteLine("NET SALARY : " + emp.CalculateSalary());


            }
            catch (LowBasicException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(emp2);
        }
    }
}