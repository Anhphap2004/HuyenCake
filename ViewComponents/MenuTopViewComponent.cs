using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HuyenCake.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly HuyenCakeContext _context;
        public MenuTopViewComponent(HuyenCakeContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menutop = await _context.Menus.OrderBy(m => m.MenuId)
                .ToListAsync();
            return View(menutop);
        }
    }
}
