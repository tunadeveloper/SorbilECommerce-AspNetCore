using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
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
            var viewModel = new ProductWithCategoryViewModel
            {
                Products = _productService.GetProductWithCategoryBL(),
                Categories = _categoryService.GetListBL()
            };
            return View(viewModel);
        }
    }
}
