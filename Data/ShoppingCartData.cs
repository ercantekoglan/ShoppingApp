using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Data
{
    static class ShoppingCartData
    {
        public static List<ShoppingCart> shoppingCarts { get; set; }            
        
        public static double totalPirce { get; set ; }
        

        static ShoppingCartData()
        {
            shoppingCarts = new List<ShoppingCart>();

        }

        public static void AddProduct(ShoppingCart shoppingCart)
        {
            var product = shoppingCarts.Where(x => x.ProductId == shoppingCart.ProductId).FirstOrDefault();

            if (product == null)
            {
                shoppingCarts.Add(shoppingCart);
            }
            else
            {
                product.Amount = product.Amount + shoppingCart.Amount;                
            }

            totalPirce = shoppingCarts.Sum(x => x.TotalPrice);
        }

        
    }
}
