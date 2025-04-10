using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    
        
            public async Task<IActionResult> Details(int id)
            {
                var product = await _context.Products
                    .Include(p => p.ProductCategory)
                    .FirstOrDefaultAsync(p => p.ProductId == id);

                if (product == null)
                {
                    return NotFound();
                }

                return View(product); 
            }
        


    }
}
