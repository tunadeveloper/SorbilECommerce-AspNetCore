using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : AdminBaseController
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

        public IActionResult DeleteBlog(int id)
        {
            var values = _blogService.GetByIdBL(id);
            _blogService.DeleteBL(values);
            return RedirectToAction("Index");
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog)
        {
           _blogService.InsertBL(blog);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBlog(int id)
        {
            var values = _blogService.GetByIdBL(id);
           return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            _blogService.UpdateBL(blog);
            return RedirectToAction("Index");
        }
    }
}
