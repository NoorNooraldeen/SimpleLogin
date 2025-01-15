using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleLogin.Data;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class AccountController : Controller
    {

        private  AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Register()
        {
            ViewBag.Roles = new SelectList(_context.Roles, "RoleId", "RoleName");
            return View();


        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);

        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, int password)
        {
            var user = _context.Users
                               .Where(u => u.Email == email && u.Password == password);
                             

            if (user.Any())
            {
                // Authentication logic here
                return RedirectToAction( "Login");
            }

            ModelState.AddModelError("", "Invalid login attempt");
            return View();
        }
    }
}
