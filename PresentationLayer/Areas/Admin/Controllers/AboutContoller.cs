using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutContoller : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutContoller(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index(int id = 1)
        {
            var values = _aboutService.GetByIdBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutService.UpdateBL(about);
            return View(about);
        }
    }
}
