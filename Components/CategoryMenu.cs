using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PlgRequest.Data;
using PlgRequest.Factory;

namespace Doc.App.Components
{  
    public class CategoryMenu : ViewComponent
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        // private readonly HttpClient _httpClient;
        private string _token;
        // private string _condisi;
        // private string _dept;
        // private string _user;
        private string _group;
        private ISession _session => this._httpContext.HttpContext.Session;        

        public CategoryMenu(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _app = app;
            _token = _session.GetString("_Tokens");
            _group =  _session.GetString("_Groups");
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var a = await ApiClientFactory.Instance.GetMenuHdr(_group, _token);
            var b = await ApiClientFactory.Instance.GetMenuDtl(_group, _token);

            ViewBag.MenuHdr = a;
            ViewBag.MenuDtl = b;
            return View();
        }        
    }
}