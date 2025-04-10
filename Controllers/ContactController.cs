using HuyenCake.Models;
using Microsoft.AspNetCore.Mvc;

namespace HuyenCake.Controllers
{
    public class ContactController : Controller
    {
        private readonly HuyenCakeContext _context;
        public ContactController(HuyenCakeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Send(string fullname, string email, string message)
        {

            var contact = new Contact()
            {
                Name = fullname,
                Email = email,
                Message = message,
                SentDate = DateTime.Now
            };


            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Gửi Liên Hệ thành công!";
            return RedirectToAction("Index");

        }
    }
}
