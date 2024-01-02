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

        //Action<Product> act = p => { p.Price += p.Price * 0.1; };
        Action<Product> act = UpdatePrice;

        //products.ForEach(act);
        products.ForEach(UpdatePrice);
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }
    }

    static void UpdatePrice(Product p)
    {
        p.Price += p.Price * 0.1;
    }
}