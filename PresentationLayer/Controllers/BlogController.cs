using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values = _blogService.GetListBL();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            var values = _blogService.GetByIdBL(id);
            return View(values);
        }
    }
}
