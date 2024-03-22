using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ShoppingCart
    {
        private Product[] products;
        private int itemCount;


        public ShoppingCart(int capacity)
        {
            this.products = new Product[capacity];
            this.itemCount = 0;
        }

        public Product[] Products
        {
            get { return products; }
            set { }
        }

        public int ItemCount
        {
            get { return itemCount; }
            set { }
        }

        public void AddProduct()
        {
            Product product1 = new ClothingProduct("Shirt", 250, ProductCategory.Clothing, "S", "black");
            itemCount++; 
            Console.WriteLine("This item has been added. " + itemCount);
            product1.GetInfo();

            Product product2 = new ElectronicsProduct("Phone", 7500, ProductCategory.Electronic, "Iphone", "15"); 
            itemCount++;
            Console.WriteLine("This item has been added. " + itemCount);
            product2.GetInfo();
        }

        public void RemoveProduct()
        {
            Product product1 = new ClothingProduct("Shirt", 250, ProductCategory.Clothing, "small", "red"); 
            itemCount--; 
            Console.WriteLine("This item has been removed. " + itemCount);
            product1.GetInfo();
            Product product2 = new ElectronicsProduct("Phone", 7500, ProductCategory.Electronic, "Iphone", "15"); 
            itemCount--; 
            Console.WriteLine("This item has been removed. " + itemCount);
            product2.GetInfo();
        }

    }
}
