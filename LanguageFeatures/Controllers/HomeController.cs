using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Hi,Carey! \r\n Current Time is: "+ DateTime.Now.ToString("yy-MMM-dd ddd HH:mm:ss");
        }

        public ViewResult AutoProperty()
        {
            Product product = new Product()
            {
                Category = "Watersports",
                Desp = "A boat for one person",
                Id = 100,
                Name = "Carey",
                Price = 275M
            };

            return View("Result", (object) string.Format("Product name:{0}", product.Name));
        }

        public ViewResult UseExtension()
        {
            // create and populate ShoppingCart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccer ball", Price = 19.50M},
                    new Product {Name = "Corner flag", Price = 34.95M}
                }
            };


            // get the total value of the products in the cart
            decimal cartTotal = cart.TotalPrices();
            return View("Result",
                (object) String.Format("Total: {0:c}", cartTotal));
        }

        //public ViewResult UseFilterExtensionMdthod()
        //{
        //    IEnumerable<Product> products = new ShoppingCart
        //    {
        //        Products = new List<Product> {
        //            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
        //            new Product {Name = "Lifejacket", Category = "Watersports",Price = 48.95M},
        //            new Product {Name = "Soccer ball", Category = "Soccer",Price = 19.50M},
        //            new Product {Name = "Corner flag", Category = "Soccer",Price = 34.95M}
        //        }
        //    };
        //    var foundProducts = products.OrderByDescending(e => e.Price).Take(3).Select(e => new { e.Name, e.Price });

        //}
    }
}
