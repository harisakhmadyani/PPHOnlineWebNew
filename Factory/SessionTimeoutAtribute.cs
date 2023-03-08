using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PlgRequest.Factory
{
    public class SessionTimeoutAtribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ses = filterContext.HttpContext.Session.GetString("_Tokens");
            var ses2 = filterContext.HttpContext.Session.GetString("_AuthGAs");

            if (ses == null)
            {
                filterContext.Result = new RedirectResult("~/PlgRequest/Login/Index");
                return;
            }
            else if(ses2 == null){
                filterContext.Result = new RedirectResult("~/PlgRequest/Login/Index");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}