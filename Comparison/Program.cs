
using Comparison.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("Tv", 900.00));
        products.Add(new Product("Notebook", 1200.00));
        products.Add(new Product("Table",450.00));

        //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

        //products.Sort(), // Forma 1, A classe products devem implementar a interface IComparable, "não é dinamica".
        //products.Sort(CompareProducts); // Forma 2, com método estático
        //products.Sort(Comp); // Forma 3, com o Comparison
        //products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Forma 4, Com expressao lambda direta



        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }

    //static int CompareProducts(Product p1, Product p2)
    //{
    //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    //}

}