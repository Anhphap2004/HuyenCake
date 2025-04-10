using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HuyenCake.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HuyenCakeContext _context;

        public HomeController(ILogger<HomeController> logger, HuyenCakeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.productCategory = _context.ProductCategories.ToList();
            return View();
        }
        public async Task<IActionResult> LoadByCategory(int categoryId)
        {
            var result = await Task.FromResult(ViewComponent("Products", new { categoryId }));
            return result;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
