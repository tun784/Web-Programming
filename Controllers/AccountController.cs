using Microsoft.AspNetCore.Mvc;
using BanHoa.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace BanHoa.Controllers
{
    public class AccountController : Controller
    {
        private readonly FlowerDbContext _context;

        public AccountController(FlowerDbContext context)
        {
            _context = context;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("SignIn");
            }

            return View(customer);
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string phoneNumber)
        {
            // Match your Customer model’s PhoneNumber property:
            var customer = _context.Customers
                .FirstOrDefault(c => c.Phone == phoneNumber);

            if (customer != null)
            {
                // Use clear session keys
                HttpContext.Session.SetInt32("CustomerID", customer.Id);
                HttpContext.Session.SetString("CustomerName", customer.Name);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid phone number!";
            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
