using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Data
{
    
    public static class ProductData
    {
        public static List<Product> products { get; set; }
        static ProductData()
        {
            products = new List<Product>();

            products.Add(new Product
            {
                Id = 1,
                Name = "IBM",
                Price = 150.000
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "Dell",
                Price = 180.000
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "HP",
                Price = 140.000
            });

            products.Add(new Product
            {
                Id = 4,
                Name = "Lenova",
                Price = 180.000
            });
        }
    
    }
}
