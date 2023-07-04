using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
           
            var product1 = new Product { Id = 1, Name = "Telefon", Price = 35.000m };
            var product2 = new Product { Id = 2, Name = "Bilgisayar", Price = 100.000m };
            var product3 = new Product { Id = 3, Name = "Tablet", Price =15.000m };

            
            var cartProduct1 = new CartProduct { Product = product1, Quantity = 5, Price = 35.000m };
            var cartProduct2 = new CartProduct { Product = product2, Quantity = 2, Price = 100.000m };
            var cartProduct3 = new CartProduct { Product = product3, Quantity = 1, Price = 15.000m };

           
            var cartProducts = new List<CartProduct> { cartProduct1, cartProduct2, cartProduct3 };

           
            var viewModel = new CartViewModel { CartProducts = cartProducts };

            return View(viewModel);
        }
    }
}
