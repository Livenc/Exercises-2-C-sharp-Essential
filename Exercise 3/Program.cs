namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Devid", "Grinch");
            employee.EmployeeSalary("Direktor", 10);
            employee.Show();



            Console.ReadLine();
        }
    }
}