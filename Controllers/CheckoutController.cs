using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MoShop.Models;
using System.Drawing;

namespace MoShop.Controllers
{

    public class CheckoutController : Controller
    {
        public  ShoppingCart _shoppingCart;
       

        public CheckoutController(ShoppingCart shoppingCart)
        { 
            _shoppingCart = shoppingCart;
        
        }
        [HttpPost]
        public IActionResult CheckoutPage(string productID, string size, string price) 
        {
            var item = new ShoppingCartItem
            {
                ShirtID = productID,
                Price = price,
                Size = size
            };

            _shoppingCart.AddItem(item);
            ViewBag.TotalItems = _shoppingCart;

            var itemsList = _shoppingCart.Items.ToList();
           

            return View(itemsList);
        }

        [HttpPost]
        public IActionResult Confirmation(string productID, string size, string price)
        {
            var item = new ShoppingCartItem
            {
                ShirtID = productID,
                Price = price,
                Size = size
            };

            _shoppingCart.AddItem(item);
            ViewBag.TotalItems = _shoppingCart;

            var itemsList = _shoppingCart.Items.ToList();
            

            return View(itemsList);
        }
    }

    

    
}
