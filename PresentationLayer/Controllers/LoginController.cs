using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
      private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var values = _userService.GetListBL().FirstOrDefault(x=>x.Username == user.Username && x.Password == user.Password);

            if (values != null)
            {
                HttpContext.Session.SetString("user", values.Username);
                return RedirectToAction("Index", "Message", new {area = "Admin"});
            }
            return View();
        }

        public IActionResult Exit()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Login");
        }
    }
}
