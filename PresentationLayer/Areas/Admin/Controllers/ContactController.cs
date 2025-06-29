using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : AdminBaseController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index(int id = 1)
        {
            var values = _contactService.GetByIdBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactService.UpdateBL(contact);
            return View(contact);
        }
    }
}
