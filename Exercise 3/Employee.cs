using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Employee
    {
        string firstName, lastName, dolgnost;
        double stag, salary, taxcaemploy;
        const double taxca = 0.2;

        public Employee(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
            dolgnost = "";
            salary = 0;
            taxcaemploy = 0;

        }
        public void EmployeeSalary(string Dolgnost, double Stag)
        {
            dolgnost = Dolgnost;
            stag = Stag;
            switch (Dolgnost)
            {
                case "Raochii":
                    salary = 1200;
                    break;
                case "Meneger":
                    salary = 1900;
                    break;
                case "Direktor":
                    salary = 2300;
                    break;
                default:
                    salary = 0;
                    break;
            }
            if (Stag <= 5)
            {
                salary = (salary * 0.2) + salary;
            }
            else if (Stag > 5 && salary <= 10)
            {
                salary = (salary * 0.5) + salary;
            }
            else if (Stag > 10 && salary <= 15)
            {
                salary = (salary * 0.7) + salary;
            }
            else if (Stag > 15 && salary <= 100)
            {
                salary = (salary * 0.9) + salary;
            }
            taxcaemploy = salary * 0.2;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {firstName}  Last name : {lastName} Dolgnost :  {dolgnost} Salary :{salary} Taxs : {taxcaemploy}"  );
        }
    }

}
