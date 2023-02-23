using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Employee
    {
        string firstName, lastName, jobTitle;
        double experience, salary, taxcaemploy;
        const double taxca = 0.2;

        public Employee(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
            jobTitle = "";
            salary = 0;
            taxcaemploy = 0;

        }
        public void EmployeeSalary(string JobTitle, double Experience)
        {
            jobTitle = JobTitle;
            experience = Experience;
            switch (JobTitle)
            {
                case "Employee":
                    salary = 1200;
                    break;
                case "Manager":
                    salary = 1900;
                    break;
                case "Director":
                    salary = 2300;
                    break;
                default:
                    salary = 0;
                    break;
            }
            if (Experience <= 5)
            {
                salary = (salary * 0.2) + salary;
            }
            else if (Experience > 5 && salary <= 10)
            {
                salary = (salary * 0.5) + salary;
            }
            else if (Experience > 10 && salary <= 15)
            {
                salary = (salary * 0.7) + salary;
            }
            else if (Experience > 15 && salary <= 100)
            {
                salary = (salary * 0.9) + salary;
            }
            taxcaemploy = salary * 0.2;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {firstName}  Last name : {lastName} JobTitle :  {jobTitle} Salary :{salary} Taxs : {taxcaemploy}"  );
        }
    }

}
