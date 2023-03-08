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
    [SessionTimeoutAtribute]
    public class MasterController : Controller
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        // private readonly HttpClient _httpClient;
        private string _token;
        private string _condisi;
        private string _dept;
        private string _user;
        private string _supplier;
        private string _group;
        private string _factAbbr;        
        private ISession _session => this._httpContext.HttpContext.Session;

        public MasterController(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._app = app;
            this._token = this._session.GetString("_Tokens");
            this._condisi = this._session.GetString("_Cos");
            this._dept = this._session.GetString("_Depts");
            this._user =  this._session.GetString("_Users");
            this._supplier = this._session.GetString("_Supplier");
            this._group =  this._session.GetString("_Groups");
            this._factAbbr = this._session.GetString("_FAbbrs");

            ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrlOnline;

            if(_condisi == "Web"){
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrlOnline;
            }else{
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrl;
            }
        }

        public async Task<IActionResult> IndexRoleDateTime(){    
            RoleDateTime dt = new RoleDateTime();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            return View(dt);
        }        

        public async Task<IActionResult> AjaxSaveRoleDateTime(RoleDateTimeDto i){
            RoleDateTime inp = new RoleDateTime();
            try
            {
                inp.OpenDate = i.openDate;
                inp.CloseDate = i.closeDate;
                inp.CreatedBy = _user;
                inp.CreatedDate = DateTime.Now;

                await ApiClientFactory.Instance.SimpanRoleDateTime(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }

        public async Task<IActionResult> AjaxGetLastRoleDateTime(){
            RoleDateTime dt = new RoleDateTime();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            return PartialView("_AjaxGetLastRoleDateTime", dt);
        }

        public async Task<IActionResult> IndexBudgetPeriod(){    
            BudgetPeriod dt = new BudgetPeriod();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            return View(dt);
        }

        public async Task<IActionResult> AjaxSaveBudgetPeriod(BudgetPeriodDto i){
            BudgetPeriod inp = new BudgetPeriod();
            try
            {
                inp.BudgetYear = i.budgetYear;
                inp.BudgetMonth = i.budgetMonth;
                inp.CreatedBy = _user;
                inp.CreatedDate = DateTime.Now;

                await ApiClientFactory.Instance.SimpanBudgetPeriod(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }        

        public async Task<IActionResult> AjaxGetLastBudgetPeriod(){
            BudgetPeriod dt = new BudgetPeriod();
            try
            {
                dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            return PartialView("_AjaxGetLastBudgetPeriod", dt);
        }

        // public async Task<IActionResult> IndexItemSupplier(){
           
        //     ItemSupplier myItem = new ItemSupplier();
        //     try
        //     {
        //         myItem = await ApiClientFactory.Instance.GetMyItem(_supplier, _group, _token);
        //     }
        //     catch (System.Exception)
        //     {
        //         myItem = null;
        //     }

        //     var a = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
            
        //     ViewBag.SubCat = a;
        //     return View(myItem);       
        // }

        public async Task<IActionResult> IndexItemSupplier(){
           
            ItemSupplier myItem = new ItemSupplier();
            var pages = 1;
            try
            {
                myItem = await ApiClientFactory.Instance.GetMyItem(_supplier, _group, pages, _token);
            }
            catch (System.Exception)
            {
                myItem = null;
            }

            var a = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
            var b = await ApiClientFactory.Instance.GetCountMyItem(_supplier, _token);
            
            ViewBag.SubCat = a;
            ViewBag.CountPage = b.CountList;
            ViewBag.CurrentPage = pages;
            return View(myItem);       
        }

        public async Task<IActionResult> AjaxGetPagesMyItem(int pages){
           
            ItemSupplier myItem = new ItemSupplier();
            try
            {
                myItem = await ApiClientFactory.Instance.GetMyItem(_supplier, _group, pages, _token);
            }
            catch (System.Exception)
            {
                myItem = null;
            }

            // var a = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
            var b = await ApiClientFactory.Instance.GetCountMyItem(_supplier, _token);
            
            // ViewBag.SubCat = a;
            ViewBag.CountPage = b.CountList;
            ViewBag.CurrentPage = pages;
            return PartialView("_AjaxGetPagesMyItem", myItem);        
        }

        public async Task<IActionResult> AjaxGetItem(string id){
            
            ItemRequest itemreq = new ItemRequest();
            try
            {
                itemreq = await ApiClientFactory.Instance.GetChooseMyItem(id, _supplier, _group, _token);
            }
            catch (System.Exception)
            {
                itemreq = null;
            }
            return PartialView("_AjaxGetItem", itemreq);            
        }

        public async Task<IActionResult> AjaxSaveMyItem(InputMyItemDto i){
            InputMyItem inp = new InputMyItem();
            try
            {
                inp.ItemID = i.itemID;
                inp.SupplierID = _supplier;
                inp.NewItemID = i.newItemID;

                StAction res = await ApiClientFactory.Instance.SimpanMyItem(inp, _token);
                return Ok(new { res });
            }
            catch (System.Exception e)
            {
                return Ok(new { msg = "not", err = e.Message });
            }
        }

        public async Task<IActionResult> AjaxRemoveMyItem(InputMyItemDto i){
            InputMyItem inp = new InputMyItem();
            try
            {
                inp.ItemID = i.itemID;
                inp.SupplierID = _supplier;
                inp.NewItemID = i.newItemID;

                StAction res = await ApiClientFactory.Instance.RemoveMyItem(inp, _token);
                return Ok(new { res });
            }
            catch (System.Exception e)
            {
                return Ok(new { msg = "not", err = e.Message });
            }
        }

        public async Task<IActionResult> IndexItemOpenPrice(){    
            var a = await ApiClientFactory.Instance.GetSubCategory(_group, _token);

            ViewBag.SubCat = a;
            return View();
        }    

        public async Task<IActionResult> AjaxRefreshItemOpenPrice(){
            ItemOpenPrice inp = new ItemOpenPrice();
            try
            {
                inp.FactAbbr = _factAbbr;
                
                await ApiClientFactory.Instance.RefreshItemOpenPrice(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception e)
            {
                return Ok(new { msg = "not", err = e.Message });
            }
        }         
        
        public async Task<IActionResult> AjaxGetItemOpenPrice(string subCat){
            
            ItemRequest itemreq = new ItemRequest();
            try
            {
                itemreq = await ApiClientFactory.Instance.GetItemOpenPrice(subCat, _factAbbr, _token);
            }
            catch (System.Exception)
            {
                itemreq = null;
            }
            return PartialView("_AjaxGetItemOpenPrice", itemreq);            
        }
    }
}