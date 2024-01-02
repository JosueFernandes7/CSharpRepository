using Predicate.Entities;

class Program
{
    static void Main(String[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Mouse", 50.00));
        products.Add(new Product("Tablet", 350.50));
        products.Add(new Product("HD Case", 80.90));


        //products.RemoveAll(p => p.Price >= 100); // com expressao lambda
        //products.RemoveAll(ProductTest);
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }
    }

    public static bool ProductTest(Product p)
    {
        return p.Price >= 100;
    }
}