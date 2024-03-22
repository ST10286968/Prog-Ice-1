using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ShoppingCartApp 
{
     class ClothingProduct : Product
    {
        private readonly string size;
        private readonly string color;

        public ClothingProduct(String name, double price, ProductCategory category, string size, string color) : base(name, price, category)
        {
            name = Name;
            price = Price;
            category = Category;
            size = Size;
            color = Color;
        }

        public string Size
        {
            get { return size; }
            set 
            {
            
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
               
            }
        }

        public string Name { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Size of the product: " + size);
            Console.WriteLine("Color of the product: " + color);

        }
    }
}
