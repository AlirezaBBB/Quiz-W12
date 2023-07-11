using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _user;

        public HomeController(ILogger<HomeController> logger, IUserRepository user)
        {
            _logger = logger;
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(User user)
        {
            var isValidUser = _user.Login(user.NationalId, user.Phone);
            if (isValidUser)
            {
                HttpContext.Session.SetString("NationalIdSession", user.NationalId);
                Response.Cookies.Append("NationalIdCoockie", user.NationalId);
                return RedirectToAction("A");
            }
            else
            {
                return View();
            }
        }

    }
}