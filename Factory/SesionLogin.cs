using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PlgRequest.Factory
{
    public class SesionLogin  : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ses2 = filterContext.HttpContext.Session.GetString("_AuthGAs");

            if(ses2 != null){
                filterContext.Result = new RedirectResult("~/PlgRequest/Home/Index");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}