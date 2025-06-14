using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.Home
{
    public class _SliderListComponentPartial:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _SliderListComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetListBL();
            return View(values);
        }
    }
}
