using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsletterController : AdminBaseController
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        public IActionResult Index()
        {
            var values = _newsletterService.GetListBL();
            return View(values);
        }

        public IActionResult DeleteNewsletter(int id)
        {
            var values = _newsletterService.GetByIdBL(id);
            _newsletterService.DeleteBL(values);
            return RedirectToAction("Index");
        }
    }
}
