using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : AdminBaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var values = _userService.GetListBL();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _userService.GetByIdBL(id);
            _userService.DeleteBL(values);
           return RedirectToAction("Index");
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
           
  _userService.InsertBL(user);
            return RedirectToAction("Index");
       
          
        }

        public IActionResult UpdateUser(int id)
        {
            var values = _userService.GetByIdBL(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateBL(user);
            return RedirectToAction("Index");
        }

    }
}
