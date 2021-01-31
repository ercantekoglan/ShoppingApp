using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Models
{
    public class ShoppingCart
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double TotalPrice {
            get
            {
                return this.Price * this.Amount;
            }
            set
            { }
        }
        public int Amount { get; set; }

        public ShoppingCart()
        {
            
        }
    }
}
