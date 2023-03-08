using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlgRequest.Models;
using PlgRequest.Factory;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using PlgRequest.Data;
using System.Net.Http;
using PlgRequest.Utility;

namespace PlgRequest.Controllers
{
    [SessionTimeoutAtribute]
    public class HomeController : Controller
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        // private readonly HttpClient _httpClient;
        private string _token;
        private string _condisi;
        private string _dept;

        private ISession _session => this._httpContext.HttpContext.Session;

        public HomeController(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._app = app;
            this._token = this._session.GetString("_Tokens");
            this._condisi = this._session.GetString("_Cos");
            this._dept = this._session.GetString("_Depts");
            //   if (this._condisi == "Web")
            ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrlOnline;
            //   else
            //     ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrl;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
