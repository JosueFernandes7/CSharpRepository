
using System.IO;
using System;
using Microsoft.Win32;
using LinqExercicio2.Entities;
using System.Globalization;

namespace LinqExercicio2
{
    class Program
    {

        static void Print<T>(IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {

            string sourcePath = @"sourcePath";

            try
            {
                StreamReader sr = new StreamReader(sourcePath);
                sr.ReadLine();

                List<User> users = new List<User>();

                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(";");
                    users.Add(new User(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));

                }

                Console.Write("Enter salary:");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2",CultureInfo.InvariantCulture)}:\r\n");
                var emails = users.Where(u => u.Salary > salary).OrderBy(u => u.Email).Select(u => u.Email);

                double sumOfSalaries = (from user in users
                                        where user.Name.StartsWith("M")
                                        select user.Salary).
                                        DefaultIfEmpty(0.0).
                                        Sum();
                Print(emails);
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumOfSalaries.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}