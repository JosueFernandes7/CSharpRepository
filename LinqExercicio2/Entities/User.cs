using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercicio2.Entities
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public User(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
