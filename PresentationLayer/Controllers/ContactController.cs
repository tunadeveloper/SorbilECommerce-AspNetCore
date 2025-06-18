using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMessageService _messageService;
        MessageValidator validator = new MessageValidator();
        public ContactController(IContactService contactService, IMessageService messageService)
        {
            _contactService = contactService;
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactService.GetListBL();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            ValidationResult results = validator.Validate(message);
            if (results.IsValid)
            {
                _messageService.InsertBL(message);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            var values = _contactService.GetListBL();
            return View(values);

        }
    }
}



