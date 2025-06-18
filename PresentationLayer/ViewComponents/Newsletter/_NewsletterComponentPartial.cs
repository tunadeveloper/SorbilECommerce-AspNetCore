using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _NewsletterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View(new Newsletter());
        }
    }
}
