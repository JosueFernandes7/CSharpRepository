using GenericsSetDictionarys.Entities;
using GenericsSetDictionarys.Services;

class Program
{
    static void Main(string[] args)
    {
        CalculationService calculationService = new CalculationService();

        //List<double> ints = new List<double>();
        //ints.Add(1);
        //ints.Add(2);
        //ints.Add(3);

        //Console.WriteLine(calculationService.Max(ints));

        //List<string> strs = new List<string>();
        //strs.Add("1");
        //strs.Add("Salve");
        //strs.Add("Gurizada");
        //Console.WriteLine(calculationService.Max(strs));

        List<Product> products = new List<Product> {
            new Product("Book",20),
            new Product("Hat",150),
            new Product("MousePad",90)
        };

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine(calculationService.Max(products));
    }
}