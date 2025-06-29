using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : AdminBaseController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult AboutUpdate(int id = 1)
        {
            var values = _aboutService.GetByIdBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            _aboutService.UpdateBL(about);
            return View(about);
        }
    }
}
