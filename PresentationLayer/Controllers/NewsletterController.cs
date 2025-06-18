using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpPost]
        public IActionResult Subscribe(Newsletter newsletter)
        {
            _newsletterService.InsertBL(newsletter);
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
