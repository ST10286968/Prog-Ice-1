
using ShoppingCartApp;

internal class Program
{

    static void Main(string[] args)
    {
        ShoppingCart myCart = new ShoppingCart(30);
        myCart.AddProduct();
        myCart.RemoveProduct();



    }
}