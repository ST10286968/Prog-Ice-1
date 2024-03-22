using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ElectronicsProduct : Product
    {
        private readonly string brand;
        private readonly string model;

        public string Brand
        {
            get { return brand; }
        }

        public string Model
        {
            get { return model; }
        }

        public ElectronicsProduct(String Name, double Price, ProductCategory Category, string Brand, string Model) : base(Name, Price, Category)
        {
           
            brand = Brand;
            model = Model;
        }


        

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Brand of the product: " + Brand);
            Console.WriteLine("Model of the product: " + Model);
        }


}
}
