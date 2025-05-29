using Microsoft.AspNetCore.Mvc;
using BanHoa.Models;
using System.Linq;
using System.Diagnostics;

namespace BanHoa.Controllers
{
    public class HomeController : Controller
    {
        private readonly FlowerDbContext _context;

        public HomeController(FlowerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}