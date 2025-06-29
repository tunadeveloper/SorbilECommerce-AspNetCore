using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : AdminBaseController
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.GetListBL();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.GetByIdBL(id);
            _messageService.DeleteBL(values);
            return RedirectToAction("Index");
        }
    }
}
