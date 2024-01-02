using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercicio.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
