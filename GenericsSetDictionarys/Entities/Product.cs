using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSetDictionarys.Entities
{
    class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product (){}
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return $"Product: {Name}, Preço: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Parameter is not an Product");
            }

            Product p2 = obj as Product;
            return Price.CompareTo(p2.Price);
        }
    }
}
