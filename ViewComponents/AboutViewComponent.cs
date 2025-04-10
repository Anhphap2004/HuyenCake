using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HuyenCake.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly HuyenCakeContext _context;
        public AboutViewComponent(HuyenCakeContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _context.Abouts.ToListAsync();
            return View(about);
        }
    }
}
