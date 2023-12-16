using Enums.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {
            Contracts = new List<HourContract>();
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = new List<HourContract>();
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue();

            }
            return sum;
        }

        public void AddContract(HourContract contract)
        {
            if (!Contracts.Contains(contract))
                Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            if (Contracts.Contains(contract))
                Contracts.Remove(contract);
        }

        public int ShowContracts()
        {
            return Contracts.Count;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Level: {this.Level}, Base Salary: {this.BaseSalary}, Departament: {this.Department.Name}, Contracts: {this.ShowContracts()}";
        }
    }
}
