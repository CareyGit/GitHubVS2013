using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Desp { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }

    public class ShoppingCart : IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            return cartParam.Products.Sum(prod => prod.Price);
        }

        
    }
}