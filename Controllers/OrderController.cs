using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using BanHoa.Models;
using BanHoa.Controllers;
using BanHoa.Models;

namespace BanHoa.Controllers
{
    public class OrderController : Controller
    {
        private readonly FlowerDbContext _context;

        public OrderController(FlowerDbContext context)
        {
            _context = context;
        }

        public IActionResult Checkout()
        {
            var customerId = HttpContext.Session.GetInt32("CustomerID");
            if (customerId == null)
                return RedirectToAction("SignIn", "Account");

            var cart = GetCart();
            if (!cart.Any())
                return RedirectToAction("Index", "Cart");

            return View(cart);
        }

        [HttpPost]
        public IActionResult Confirm(string deliveryAddress)
        {
            var customerId = HttpContext.Session.GetInt32("CustomerID");
            if (customerId == null)
                return RedirectToAction("SignIn", "Account");

            var cart = GetCart();
            if (!cart.Any())
                return RedirectToAction("Index", "Cart");

            var order = new Order
            {
                CustomerID = customerId.Value,
                OrderDate = DateTime.Now,
                DeliveryAddress = deliveryAddress,
                TotalPrice = (double)cart.Sum(i => i.Product.Price * i.Quantity)
            };

            _context.Orders.Add(order);

            foreach (var item in cart)
            {
                _context.OrderDetails.Add(new OrderDetail
                {
                    OrderID = order.OrderID,
                    ProductID = item.Product.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.Product.Price
                });

                var product = _context.Products.Find(item.Product.ProductID);
                if (product != null)
                    product.StockQuantity -= item.Quantity;
            }

            SaveCart(new List<CartItem>());

            return RedirectToAction("Success");
        }

        public IActionResult Success() => View();

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
}
