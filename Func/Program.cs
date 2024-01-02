using Predicate.Entities;
using System.Runtime.CompilerServices;
using System.Linq;

public static class ListExtensions
{
    public static void ShowList<T>(this List<T> list){ 
        foreach (T item in list)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main(String[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Mouse", 50.00));
        products.Add(new Product("Tablet", 350.50));
        products.Add(new Product("HD Case", 80.90));

        ListExtensions.ShowList(products);

        Func<Product, string> func = NameUpper;


        //List<string> result = products.Select(NameUpper).ToList();
        List<string> result = products.Select(func).ToList();

        ListExtensions.ShowList(result);
    }

    static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }


}