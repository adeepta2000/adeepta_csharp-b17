using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product() : this("Product Name", 0.0)
        {

        }

        public Product(string name, double price) : this(name, price, "Product Description", "Product Color")
        {

        }

        public Product(string name, double price, string description, string color)
        {
            Name = name;
            Price = price;
            Description = description;
            Color = color;
        }
    }
}
