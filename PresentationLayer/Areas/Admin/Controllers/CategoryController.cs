using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : AdminBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.GetListBL();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = _categoryService.GetByIdBL(id);
            _categoryService.DeleteBL(values);
            return RedirectToAction("Index");
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.InsertBL(category);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.GetByIdBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.UpdateBL(category);
            return RedirectToAction("Index");
        }
    }
}
