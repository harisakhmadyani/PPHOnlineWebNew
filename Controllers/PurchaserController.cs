using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PlgRequest.Data;
using PlgRequest.Factory;
using PlgRequest.Models;
using PlgRequest.Utility;

namespace PlgRequest.Controllers
{
    [SessionTimeoutAtribute]
    public class PurchaserController : Controller
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        private readonly HttpClient _httpClient;
        private string _token;
        private string _condisi;
        private string _dept;
        private string _user;
        private string _group;
        private string _factAbbr;
        private ISession _session => this._httpContext.HttpContext.Session;

        public PurchaserController(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._httpClient = new HttpClient();
            this._app = app;
            this._token = this._session.GetString("_Tokens");
            this._condisi = this._session.GetString("_Cos");
            this._dept = this._session.GetString("_Depts");
            this._user = this._session.GetString("_Users");
            this._group =  this._session.GetString("_Groups");
            this._factAbbr = this._session.GetString("_FAbbrs");

            ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrlOnline;

            if(_condisi == "Web"){
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrlOnline;
            }else{
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrl;
            }
        }

        public async Task<IActionResult> Index(){
            SubCategory dt = new SubCategory();
            try
            {
                dt = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            
            return View(dt);
        }

        public async Task<IActionResult> AjaxGetItem(string id){
            ItemRequest itemreq = new ItemRequest();
            try
            {
                itemreq = await ApiClientFactory.Instance.GetPriceItem(id, _group, _factAbbr, _token);
            }
            catch (System.Exception)
            {
                itemreq = null;
            }
            return PartialView("_AjaxGetItem", itemreq);
        }

        public async Task<IActionResult> AjaxSaveToPPH(string item, string supp, string period){
            var dt = new ImportToPPH {
                ItemID = item,
                SupplierID = supp,
                Period = period,
                FactAbbr = _factAbbr,
                User = _user
            };

            try
            {
                StAction dts  = await ApiClientFactory.Instance.SimpanPrice2(dt, _token);
                return Ok(new {msg2 = "ok", dts });
            }
            catch (System.Exception)
            {
                return Ok(new { msg2 = "not" });
            }
        }

        public async Task<IActionResult> Index2(){  
            ItemRequest dt = new ItemRequest();
            try
            {
                dt = await ApiClientFactory.Instance.GetPriceNewItem(_factAbbr, _token);
            }
            catch (System.Exception)
            {
                dt = null;
            }          
            return View(dt);
        }

        public async Task<IActionResult> AjaxUpdateToNewItem(long id){
            var dt = new UpdateToNewItem {
                Id = id,
                User = _user,
                Factory = _factAbbr
            };

            try
            {
                StAction dts  = await ApiClientFactory.Instance.UpdatePriceNewItem(dt, _token);
                return Ok(new {msg2 = "ok", dts });
            }
            catch (System.Exception)
            {
                return Ok(new { msg2 = "not" });
            }
        }

        public async Task<IActionResult> DownloadFile(string filename)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                var queryString = "?filename=" + filename;
                var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/DownloadFile"), queryString);
                var response = await _httpClient.GetAsync(uri.ToString());

                var ext = ApiClientFactory.Instance.GetContentType(filename);

                if (response.IsSuccessStatusCode)
                {
                    System.Net.Http.HttpContent content = response.Content;
                    var contentStream = await content.ReadAsStreamAsync(); // get the actual content stream
                    return File(contentStream, ext, filename);
                }else{
                    throw new FileNotFoundException();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            
        }          
    }
}