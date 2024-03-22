using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public enum ProductCategory
    {
        Clothing, //Clothing products
        Electronic, //Electronics products
        Home, //Home products
        Beauty, //Beauty products
        Groceries //Grocery products
    }


    class Product
    { 

        private String name;
        private double price;
        private ProductCategory category;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value == price)
                {
                    price = value;
                }
                else
                {
                    price = 100;
                }

            }
        }

        public ProductCategory Category
        {
            get { return category; }
            set { }
        }

        public Product(string name, double price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        

       

        public virtual void GetInfo()
        {
            Console.WriteLine("Name of the product: " + Name);
            Console.WriteLine("Price of the product: " + Price);
            Console.WriteLine("Category of the product: " + Category);
        }

    }

}

