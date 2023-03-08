using System;
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
    public class UtilitysController : Controller
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        // private readonly HttpClient _httpClient;
        private string _token;
        private string _condisi;
        private string _dept;
        private string _user;
        private string _group;
        private ISession _session => this._httpContext.HttpContext.Session;

        public UtilitysController(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._app = app;
            this._token = this._session.GetString("_Tokens");
            this._condisi = this._session.GetString("_Cos");
            this._dept = this._session.GetString("_Depts");
            this._user =  this._session.GetString("_Users");
            this._group =  this._session.GetString("_Groups");
            ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrlOnline;

            if(_condisi == "Web"){
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrlOnline;
            }else{
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrl;
            }
        }

        public IActionResult GetDateTimeNow(){
            return Ok(new {dtNw = DateTime.Now});
        }

        public async Task<IActionResult> GetLastRoleDateTimeWidget1(){    
            RoleDateTime dt = new RoleDateTime();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastRoleDateTimeWidget1(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }

            DateTimeNow dt2 = new DateTimeNow();
            try
            {
                dt2 = await ApiClientFactory.Instance.GetDateTimeNow(_token);
            }
            catch (System.Exception)
            {
                dt2 = null;
            }

            BudgetPeriod dt3 = new BudgetPeriod();
            try
            {
                dt3 = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
            }
            catch (System.Exception)
            {
                dt3 = null;
            }

            return Ok(new {clsDt = dt.CloseDate, dtNw = dt2.dateTimeNow, prdMn = dt3.BudgetMonth, prdYr = dt3.BudgetYear});
        }

        public async Task<IActionResult> GetLastRoleDateTimeWidget2(){    
            RoleDateTime dt = new RoleDateTime();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastRoleDateTimeWidget2(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }

            return Ok(new {clDt = dt.CloseDate});
        }

        public async Task<IActionResult> IndexGroupAccess(){
           
            GroupAccess group = new GroupAccess();
            try
            {
                group = await ApiClientFactory.Instance.GetGroupAccess(_token);
            }
            catch (System.Exception)
            {
                group = null;
            }
            return View(group);       
        }

        public async Task<IActionResult> AjaxSaveGroupAccess(InputGroupAccessDto i){
            InputGroupAccess inp = new InputGroupAccess();
            try
            {
                inp.GroupAccessID = i.groupAccessID;
                inp.GroupAccessName = i.groupAccessName;
                inp.CreatedBy = _user;
                inp.CreatedDate = DateTime.Now;
                await ApiClientFactory.Instance.SimpanGroupAccess(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }

        public async Task<IActionResult> AjaxUpdateGroupAccess(InputGroupAccessDto i){
            InputGroupAccess inp = new InputGroupAccess();
            try
            {
                inp.GroupAccessID = i.groupAccessID;
                inp.GroupAccessName = i.groupAccessName;
                inp.UpdatedBy = _user;
                inp.UpdatedDate = DateTime.Now;
                await ApiClientFactory.Instance.UpdateGroupAccess(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }

        public async Task<IActionResult> AjaxDeleteGroupAccess(InputGroupAccessDto i){
            InputGroupAccess inp = new InputGroupAccess();
            try
            {
                inp.GroupAccessID = i.groupAccessID;
                inp.DeletedBy = _user;
                inp.DeletedDate = DateTime.Now;
                await ApiClientFactory.Instance.DeleteGroupAccess(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }

        public async Task<IActionResult> IndexMenuAccess(string id){
            var a = await ApiClientFactory.Instance.GetMenuHdr(id, _token);
            var b = await ApiClientFactory.Instance.GetMenuDtl(id, _token);
            var c = await ApiClientFactory.Instance.GetAllMenuHdr(_token);
            var d = await ApiClientFactory.Instance.GetAllMenuDtl(_token);
            var e = await ApiClientFactory.Instance.GetGroupAccessByID(id, _token);

            ViewBag.MenuHdrAccess = a;
            ViewBag.MenuDtlAccess = b;
            ViewBag.MenuHdr = c;
            ViewBag.MenuDtl = d;
            return View();
        }   
    }
}