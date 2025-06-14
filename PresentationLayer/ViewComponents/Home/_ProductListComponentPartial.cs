using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.ViewComponents.Home
{
    public class _ProductListComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public _ProductListComponentPartial(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
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
