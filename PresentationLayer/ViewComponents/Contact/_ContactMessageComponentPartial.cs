using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.Contact
{
    public class _ContactMessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
