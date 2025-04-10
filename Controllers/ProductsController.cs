using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;

namespace HuyenCake.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HuyenCakeContext _context;
        public ProductsController(HuyenCakeContext context)
        {
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

    }
}
