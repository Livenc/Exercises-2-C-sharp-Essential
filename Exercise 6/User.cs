using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class User
    {
        string login, firstName, lastName;
        int age;
        DateTime dateTime;

        public string Login { get { return login; }
        }
        public string FirstName { get { return firstName;} }
        public string LastName { get { return lastName;} }
        public int Age { get { return age;} }
        public DateTime DateTime { get { return dateTime; } }

        public User(string Login,string FirstName,string LastName,int Age)
        {
            login  = Login;
            firstName  = FirstName;
            lastName = LastName;
            age = Age;
            dateTime = DateTime.Now;
        }
        public void Show()
        {
            Console.WriteLine($"Login : {Login}  Firstname : {FirstName} Lastname : {lastName}  Age : {Age} Datatime {DateTime}");
        }
    }
}
