using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _productService.GetProductWithCategoryBL();
            return View(values);
        }

        public IActionResult MakePopular(int id)
        {
            var values = _productService.GetByIdBL(id);
            values.IsPopular = true;
            _productService.UpdateBL(values);
            return RedirectToAction("Index");
        }

        public IActionResult RemovePopular(int id)
        {
            var values = _productService.GetByIdBL(id);
            values.IsPopular = false;
            _productService.UpdateBL(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
          ViewBag.Categories= _categoryService.GetListBL();
            ViewBag.PopularOptions = new List<SelectListItem>
            {
                new SelectListItem{Text = "Popüler Olsun", Value="true"},
                 new SelectListItem{Text = "Popüler Olmasın", Value="false"}
            };
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.InsertBL(product);
            ViewBag.Categories = _categoryService.GetListBL();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            ViewBag.Categories = _categoryService.GetListBL();
            ViewBag.PopularOptions = new List<SelectListItem>
            {
                new SelectListItem{Text = "Popüler Olsun", Value="true"},
                 new SelectListItem{Text = "Popüler Olmasın", Value="false"}
            };
            var values = _productService.GetByIdBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.UpdateBL(product);
            ViewBag.Categories = _categoryService.GetListBL();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id) {
            var values = _productService.GetByIdBL(id);
            _productService.DeleteBL(values);
            return RedirectToAction("Index");
            }
    }
}
