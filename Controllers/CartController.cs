using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using BanHoa.Models;

namespace BanHoa.Controllers
{
    public class CartController : Controller
    {
        private readonly FlowerDbContext _context;

        public CartController(FlowerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.Product.ProductID == id);

            if (item != null) item.Quantity++;
            else cart.Add(new CartItem { Product = product, Quantity = 1 });

            SaveCart(cart);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var cart = GetCart();
            cart.RemoveAll(p => p.Product.ProductID == id);
            SaveCart(cart);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            SaveCart(new List<CartItem>());
            return RedirectToAction("Index");
        }

        private List<CartItem> GetCart()
        {
            var json = HttpContext.Session.GetString("Cart");
            return string.IsNullOrEmpty(json) ? new List<CartItem>() : JsonSerializer.Deserialize<List<CartItem>>(json);
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
        }
    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
