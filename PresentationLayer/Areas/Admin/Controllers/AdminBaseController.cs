using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PresentationLayer.Areas.Admin.Controllers
{
    public class AdminBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetString("user");
            if (string.IsNullOrEmpty(user))
            {
                context.Result = new RedirectToActionResult("Index", "Login", new { area = "" });
            }
            base.OnActionExecuting(context);
        }
    }
}
