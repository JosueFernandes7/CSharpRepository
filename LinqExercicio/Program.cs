using LinqExercicio.Entities;
using System.IO;
using System;
using Microsoft.Win32;

namespace LinqExercicio
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
                string[] lines = File.ReadAllLines(sourcePath);
                List<Product> products = new List<Product>();
                for(int i = 1; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split(";");
                    products.Add(new Product() {Name = line[0], Price = double.Parse(line[1])});
                }
                double avg = (from p in products select p.Price).Average();
                var r1 = (from p in products
                          where p.Price < avg
                          select p.Name);
                Print(r1);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}