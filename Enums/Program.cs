using Enums.Entities;
using Enums.Entities.Enums;
using System.Globalization;
namespace Enums
{

    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Worker worker = new Worker();

            Console.Write("Enter deparment's name: ");
            department.Name = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine();
            Console.Write("Level (Junior,MidLevel,Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());
            int i = 1;
            while (contracts != 0)
            {
                HourContract hourContract = new HourContract();
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                hourContract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                hourContract.ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                hourContract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(hourContract);
                i++;
                contracts--;
            }

            Console.Write("Enter a month and year to calculate income (MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Name {worker.Name} \nDepartment: {department.Name}\nIncome for {data.Month}/{data.Year}: {worker.Income(data.Year,data.Month).ToString("F2")}");

        }

    }
}