using ShoppingApp.Data;
using ShoppingApp.Models;
using System;
using System.Linq;

namespace ShoppingApp
{
    class Program
    {
        static void ProductList(bool isFirstTime)
        {
            if (isFirstTime)
            {
                Console.WriteLine("Sepete eklemek istediğiniz ürünün numarasını giriniz ya da çıkma için '101' yazınız...:");
                foreach (var item in ProductData.products)
                {
                    Console.WriteLine($"No:{item.Id} - {item.Name} Fiyatı:{item.Price}");
                }

            }
        }

        static void Main(string[] args)
        {

            bool isFirstTime = true;
            int exit=0;


            while (exit != 101)
            {

                

                ProductList(isFirstTime);
                isFirstTime = false;

                
                var productNumber = Convert.ToInt32(Console.ReadLine());
                exit = productNumber;
                if (exit == 101)
                    return;

                Product selectedProduct = ProductData.products.Where(p => p.Id == productNumber).FirstOrDefault();

                Console.WriteLine("Sepete eklemek istediğiniz ürünün miktarını giriniz ya çıkmak için '101' yazınız...:");                
                var productAmount = Convert.ToInt32(Console.ReadLine());
                exit = productAmount;
                if (exit == 101)
                    return;

                ShoppingCart shoppingCart = new ShoppingCart();
                shoppingCart.ProductId = productNumber;
                shoppingCart.ProductName = selectedProduct.Name;
                shoppingCart.Price = selectedProduct.Price;
                shoppingCart.Amount = productAmount;

                ShoppingCartData.AddProduct(shoppingCart);

                Console.WriteLine(productNumber + "-" + selectedProduct.Name);

                Console.WriteLine("Sepeteki ürünler...:");
                foreach (var item in ShoppingCartData.shoppingCarts)
                {
                    Console.WriteLine($"No:{item.ProductId} - {item.ProductName} -Adet: {item.Amount} - Fiyatı:{item.Price}-{item.TotalPrice}");                    
                }
                Console.WriteLine("Sepet toplamı...:" + ShoppingCartData.totalPirce.ToString());

            }
        }
    }
}
