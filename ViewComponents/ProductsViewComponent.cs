using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HuyenCake.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly HuyenCakeContext _context;
        public ProductsViewComponent(HuyenCakeContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? categoryId)
        {
            ViewBag.productCategory = await _context.ProductCategories.ToListAsync();

            var products = await _context.Products
                .Include(p => p.ProductCategory)
                .Where(p => !categoryId.HasValue || p.ProductCategoryId == categoryId)
                .ToListAsync();

            return View(products);
        }
    }
}
