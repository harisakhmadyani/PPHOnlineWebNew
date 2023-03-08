using System;
using System.Collections.Generic;
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
    public class SupplierController : Controller
    {
        private readonly IOptions<MySetting> _app;
        private readonly IHttpContextAccessor _httpContext;
        private readonly HttpClient _httpClient;
        private string _token;
        private string _condisi;
        private string _dept;
        private string _user;
        private string _supplier;
        private string _group;
        private ISession _session => this._httpContext.HttpContext.Session;

        public SupplierController(IOptions<MySetting> app, IHttpContextAccessor httpContext)
        {
            this._httpContext = httpContext;
            this._httpClient = new HttpClient();
            this._app = app;
            this._token = this._session.GetString("_Tokens");
            this._condisi = this._session.GetString("_Cos");
            this._dept = this._session.GetString("_Depts");
            this._user = this._session.GetString("_Users");
            this._supplier = this._session.GetString("_Supplier");
            this._group =  this._session.GetString("_Groups");
            ApplicationSettings.webApiUrl = this._app.Value.WebApiBaseUrlOnline;

            if(_condisi == "Web"){
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrlOnline;
            }else{
                ApplicationSettings.webApiUrl = _app.Value.WebApiBaseUrl;
            }
        }

        public IActionResult Index0(){            
            return View();
        }

        public async Task<IActionResult> Index(){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                // SubCategory dt = new SubCategory();
                // try
                // {
                //     dt = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
                // }
                // catch (System.Exception)
                // {
                //     dt = null;
                // }               
                // return View(dt);

                var a = await ApiClientFactory.Instance.GetSubCategory(_group, _token);
                var b = await ApiClientFactory.Instance.GetCurrency(_group, _token);

                ViewBag.SubCat = a;
                ViewBag.Curr = b;
                return View();
            }                    
        }

        // public async Task<IActionResult> Index2(){
        //     RoleDateTime clsDt = new RoleDateTime();
        //     try
        //     {
        //         clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
        //     }
        //     catch (System.Exception)
        //     {
        //         clsDt = null;
        //     }

        //     DateTimeNow dt2 = new DateTimeNow();
        //     try
        //     {
        //         dt2 = await ApiClientFactory.Instance.GetDateTimeNow(_token);
        //     }
        //     catch (System.Exception)
        //     {
        //         dt2 = null;
        //     }

        //     if(dt2.dateTimeNow > clsDt.CloseDate)
        //     {
        //         return Redirect("Index0");
        //     } 
        //     else 
        //     {
        //         ItemRequest myProductItems = new ItemRequest();
        //         try
        //         {
        //             myProductItems = await ApiClientFactory.Instance.GetMyProductItem(_supplier, _group, _token);
        //         }
        //         catch (System.Exception)
        //         {
        //             myProductItems = null;
        //         }

        //         var b = await ApiClientFactory.Instance.GetCurrency(_group, _token);

        //         ViewBag.Curr = b;
        //         return View(myProductItems);
        //     }                    
        // }

        public async Task<IActionResult> Index2(){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                ItemRequest myProductItems = new ItemRequest();
                var pages = 1;
                try
                {
                    myProductItems = await ApiClientFactory.Instance.GetMyProductItem(_supplier, _group, pages, _token);
                }
                catch (System.Exception)
                {
                    myProductItems = null;
                }

                var a = await ApiClientFactory.Instance.GetCurrency(_group, _token);
                var b = await ApiClientFactory.Instance.GetCountMyProductItem(_supplier, _token);

                ViewBag.Curr = a;
                ViewBag.CountPage = b.CountList;
                ViewBag.CurrentPage = pages;
                return View(myProductItems);
            }                    
        }

        public async Task<IActionResult> AjaxGetPagesMyProductItem(int pages){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                ItemRequest myProductItems = new ItemRequest();
                try
                {
                    myProductItems = await ApiClientFactory.Instance.GetMyProductItem(_supplier, _group, pages, _token);
                }
                catch (System.Exception)
                {
                    myProductItems = null;
                }

                // var a = await ApiClientFactory.Instance.GetCurrency(_group, _token);
                var b = await ApiClientFactory.Instance.GetCountMyProductItem(_supplier, _token);

                // ViewBag.Curr = a;
                ViewBag.CountPage = b.CountList;
                ViewBag.CurrentPage = pages;
                return PartialView("_AjaxGetPagesMyProductItem", myProductItems);
            }                    
        }

        // public async Task<IActionResult> DownloadMyProductItem()
        // {
        //     try
        //     {
        //         _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        //         var queryString = "?sup=" + _supplier + "&group=" + _group;
        //         var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/DownloadMyProductItem"), queryString);
        //         var response = await _httpClient.GetAsync(uri.ToString());

        //         string contentType = "application/pdf";
        //         //Define the file name
        //         string fileName = "PPH_MyProductItem_" + DateTime.Now + ".pdf";

        //         if (response.IsSuccessStatusCode)
        //         {
        //             System.Net.Http.HttpContent content = response.Content;
        //             var contentStream = await content.ReadAsStreamAsync(); // get the actual content stream
        //             return File(contentStream, contentType, fileName);
        //         }else{
        //             throw new FileNotFoundException();
        //         }
        //     }
        //     catch (System.Exception)
        //     {
        //          throw;
        //     }
        // }  

        public async Task<IActionResult> DownloadMyProductItem(int pages)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                var queryString = "?sup=" + _supplier + "&group=" + _group + "&pages=" + pages;
                var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/DownloadMyProductItem"), queryString);
                var response = await _httpClient.GetAsync(uri.ToString());

                string contentType = "application/pdf";
                //Define the file name
                string fileName = "PPH_MyProductItem_" + DateTime.Now + ".pdf";

                if (response.IsSuccessStatusCode)
                {
                    System.Net.Http.HttpContent content = response.Content;
                    var contentStream = await content.ReadAsStreamAsync(); // get the actual content stream
                    return File(contentStream, contentType, fileName);
                }else{
                    throw new FileNotFoundException();
                }
            }
            catch (System.Exception)
            {
                 throw;
            }
        }  

        public async Task<IActionResult> Index3(){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                ItemRequest myPrice = new ItemRequest();
                try
                {
                    myPrice = await ApiClientFactory.Instance.GetMyPrice(_supplier, _group, _token);
                }
                catch (System.Exception)
                {
                    myPrice = null;
                }

                // var a = await ApiClientFactory.Instance.GetMyPrice(_supplier, _group, _token);    
                var b = await ApiClientFactory.Instance.GetCurrency(_group, _token);

                BudgetPeriod c = new BudgetPeriod();
                c = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);

                // ViewBag.price = a;
                ViewBag.Curr = b;
                ViewBag.Prd = c.BudgetMonth +'-'+ c.BudgetYear;
                return View(myPrice);
            }                    
        }

        public async Task<IActionResult> Index5(){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                ItemRequest newProductItems = new ItemRequest();
                try
                {
                    newProductItems = await ApiClientFactory.Instance.GetNewProductItem(_supplier, _group, _token);
                }
                catch (System.Exception)
                {
                    newProductItems = null;
                }

                var a = await ApiClientFactory.Instance.GetCurrency(_group, _token);

                ViewBag.Curr = a;
                return View(newProductItems);
            }                    
        }

        public IActionResult Index4(){
            return View();                  
        }

        public async Task<IActionResult> AjaxGetItem(string id){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                ItemRequest itemreq = new ItemRequest();
                try
                {
                    itemreq = await ApiClientFactory.Instance.GetProductItem(id, _supplier, _group, _token);
                }
                catch (System.Exception)
                {
                    itemreq = null;
                }
                return PartialView("_AjaxGetItem", itemreq);
            }
        }

        public async Task<IActionResult> AjaxSaveItem(InputPriceDto i){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                BudgetPeriod dt = new BudgetPeriod();
                try
                {
                    dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
                }
                catch (System.Exception)
                {
                    dt = null;
                }
                var period = dt.BudgetMonth+"-"+dt.BudgetYear;
                
                InputPrice inp = new InputPrice();
                try
                {
                    // int bulan = DateTime.Now.Month;
                    // int tahun = DateTime.Now.Year;
                    // string per = bulan.ToString() + "-" + tahun.ToString();
                    inp.SupplierId = _supplier;
                    inp.ItemId = i.item;
                    inp.Qnty = i.qnty;
                    inp.Qtyrt = i.qtyrt;
                    inp.Harga = i.price;
                    inp.Currency = i.cur;
                    inp.ValidUntil = i.valid;
                    inp.DeliveryDate = i.deliv;
                    inp.Periode = period;
                    inp.CreatedBy = _user;
                    //inp.CreatedDate = DateTime.Now;
                    // inp.Id = i.id;
                    inp.Remark = i.remark;
                    inp.NewItemID = i.newitem;
                    inp.Factory = i.factory;

                    StAction res = await ApiClientFactory.Instance.SimpanPrice(inp, _token);
                    return Ok(new { res });
                }
                catch (System.Exception e)
                {
                    return Ok(new { msg = "not", err = e.Message });
                }
            }
        }

        public async Task<IActionResult> AjaxUpdateItem(InputPriceDto i){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                BudgetPeriod dt = new BudgetPeriod();
                try
                {
                    dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
                }
                catch (System.Exception)
                {
                    dt = null;
                }
                var period = dt.BudgetMonth+"-"+dt.BudgetYear;
                
                InputPrice inp = new InputPrice();
                try
                {
                    inp.SupplierId = _supplier;
                    inp.ItemId = i.item;
                    inp.NewItemID = i.newitem;
                    //inp.qnty = i.qnty;
                    //inp.qtyrt = i.qtyrt;
                    inp.Harga = i.price;
                    inp.Currency = i.cur;
                    inp.ValidUntil = i.valid;
                    inp.DeliveryDate = i.deliv;
                    inp.Periode = period;
                    inp.UpdatedBy = _user;
                    inp.UpdatedDate = DateTime.Now;
                    inp.Id = i.id;
                    inp.Remark = i.remark;

                    StAction res = await ApiClientFactory.Instance.UpdatePrice(inp, _token);
                    return Ok(new { res });
                }
                catch (System.Exception e)
                {
                    return Ok(new { msg = "not", err = e.Message });
                }
            }
        }

        public async Task<IActionResult> AjaxSaveItem5(InputPriceDtoUpload docFile){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                BudgetPeriod dt = new BudgetPeriod();
                try
                {
                    dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
                }
                catch (System.Exception)
                {
                    dt = null;
                }
                var period = dt.BudgetMonth+"-"+dt.BudgetYear;
                
                var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SavePrice5"));
                try
                {
                    if (docFile.file != null && docFile.file.Length > 0)
                    {
                        var values = new[]
                        {
                            new KeyValuePair<string, string>("SupplierId", _supplier),
                            new KeyValuePair<string, string>("ItemId", docFile.item),
                            new KeyValuePair<string, string>("Qnty", docFile.qnty.ToString()),
                            new KeyValuePair<string, string>("Qtyrt", docFile.qtyrt.ToString()),
                            new KeyValuePair<string, string>("Harga", docFile.price.ToString()),
                            new KeyValuePair<string, string>("Currency", docFile.cur),
                            new KeyValuePair<string, string>("ValidUntil", docFile.valid.ToShortDateString()),
                            new KeyValuePair<string, string>("DeliveryDate", docFile.valid.ToShortDateString()),
                            new KeyValuePair<string, string>("Periode", period),
                            new KeyValuePair<string, string>("CreatedBy", _user),
                            new KeyValuePair<string, string>("Remark", docFile.remark),
                            new KeyValuePair<string, string>("NewItemID", docFile.newitem),
                            new KeyValuePair<string, string>("Factory", docFile.factory),
                            new KeyValuePair<string, string>("FileName", docFile.filename),
                            new KeyValuePair<string, string>("ChangeName", docFile.changename)
                        };
                        
                        byte[] data;
                        using (var br = new BinaryReader(docFile.file.OpenReadStream()))
                            data = br.ReadBytes((int)docFile.file.OpenReadStream().Length);
                        ByteArrayContent bytes = new ByteArrayContent(data);
                        MultipartFormDataContent multiContent = new MultipartFormDataContent();
                        multiContent.Add(bytes, "file", docFile.file.FileName);

                        foreach (var keyValuePair in values)
                        {
                            multiContent.Add(new StringContent(keyValuePair.Value), keyValuePair.Key);
                        }

                        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                        var result = await _httpClient.PostAsync(uri.ToString(), multiContent);
                        return Ok(new {msg = "Success To Save"});
                    }

                    return BadRequest(Ok(new {sts = "File not found!"}));
                }
                catch (System.Exception e)
                {
                    return BadRequest(Ok(new {sts = e.Message}));
                    throw;
                }

                // InputPrice inp = new InputPrice();
                // try
                // {
                //     // int bulan = DateTime.Now.Month;
                //     // int tahun = DateTime.Now.Year;
                //     // string per = bulan.ToString() + "-" + tahun.ToString();
                //     inp.SupplierId = _supplier;
                //     inp.ItemId = i.item;
                //     inp.Qnty = i.qnty;
                //     inp.Qtyrt = i.qtyrt;
                //     inp.Harga = i.price;
                //     inp.Currency = i.cur;
                //     inp.ValidUntil = i.valid;
                //     inp.DeliveryDate = i.deliv;
                //     inp.Periode = period;
                //     inp.CreatedBy = _user;
                //     //inp.CreatedDate = DateTime.Now;
                //     // inp.Id = i.id;
                //     inp.Remark = i.remark;
                //     inp.NewItemID = i.newitem;
                //     inp.Factory = i.factory;

                //     StAction res = await ApiClientFactory.Instance.SimpanPrice(inp, _token);
                //     return Ok(new { res });
                // }
                // catch (System.Exception e)
                // {
                //     return Ok(new { msg = "not", err = e.Message });
                // }
            }
        }

        public async Task<IActionResult> AjaxUpdateItem5(InputPriceDtoUpload docFile){
            RoleDateTime clsDt = new RoleDateTime();
            try
            {
                clsDt = await ApiClientFactory.Instance.GetLastRoleDateTime(_token);
            }
            catch (System.Exception)
            {
                clsDt = null;
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

            if(dt2.dateTimeNow > clsDt.CloseDate)
            {
                return Redirect("Index0");
            } 
            else 
            {
                BudgetPeriod dt = new BudgetPeriod();
                try
                {
                    dt = await ApiClientFactory.Instance.GetLastBudgetPeriod(_token);
                }
                catch (System.Exception)
                {
                    dt = null;
                }
                var period = dt.BudgetMonth+"-"+dt.BudgetYear;
                
                var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/UpdatePrice5"));
                try
                {
                    if (docFile.file != null && docFile.file.Length > 0)
                    {
                        var values = new[]
                        {
                            new KeyValuePair<string, string>("SupplierId", _supplier),
                            new KeyValuePair<string, string>("ItemId", docFile.item),
                            new KeyValuePair<string, string>("Harga", docFile.price.ToString()),
                            new KeyValuePair<string, string>("Currency", docFile.cur),
                            new KeyValuePair<string, string>("ValidUntil", docFile.valid.ToShortDateString()),
                            new KeyValuePair<string, string>("DeliveryDate", docFile.valid.ToShortDateString()),
                            new KeyValuePair<string, string>("Periode", period),
                            new KeyValuePair<string, string>("UpdatedBy", _user),
                            new KeyValuePair<string, string>("Remark", docFile.remark),
                            new KeyValuePair<string, string>("NewItemID", docFile.newitem),
                            new KeyValuePair<string, string>("FileName", docFile.filename),
                            new KeyValuePair<string, string>("ChangeName", docFile.changename)
                        };
                        
                        byte[] data;
                        using (var br = new BinaryReader(docFile.file.OpenReadStream()))
                            data = br.ReadBytes((int)docFile.file.OpenReadStream().Length);
                        ByteArrayContent bytes = new ByteArrayContent(data);
                        MultipartFormDataContent multiContent = new MultipartFormDataContent();
                        multiContent.Add(bytes, "file", docFile.file.FileName);

                        foreach (var keyValuePair in values)
                        {
                            multiContent.Add(new StringContent(keyValuePair.Value), keyValuePair.Key);
                        }

                        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                        var result = await _httpClient.PostAsync(uri.ToString(), multiContent);
                        return Ok(new {msg = "Success To Save"});
                    }

                    return BadRequest(Ok(new {sts = "File not found!"}));
                }
                catch (System.Exception e)
                {
                    return BadRequest(Ok(new {sts = e.Message}));
                    throw;
                }
                // InputPrice inp = new InputPrice();
                // try
                // {
                //     inp.SupplierId = _supplier;
                //     inp.ItemId = i.item;
                //     inp.NewItemID = i.newitem;
                //     //inp.qnty = i.qnty;
                //     //inp.qtyrt = i.qtyrt;
                //     inp.Harga = i.price;
                //     inp.Currency = i.cur;
                //     inp.ValidUntil = i.valid;
                //     inp.DeliveryDate = i.deliv;
                //     inp.Periode = period;
                //     inp.UpdatedBy = _user;
                //     inp.UpdatedDate = DateTime.Now;
                //     inp.Id = i.id;
                //     inp.Remark = i.remark;

                //     StAction res = await ApiClientFactory.Instance.UpdatePrice(inp, _token);
                //     return Ok(new { res });
                // }
                // catch (System.Exception e)
                // {
                //     return Ok(new { msg = "not", err = e.Message });
                // }
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

        public async Task<IActionResult> AjaxGetMonMyprice(string month, string year){
            var prd = month + "-" + year;
            ItemRequest itemreq = new ItemRequest();
            try
            {
                itemreq = await ApiClientFactory.Instance.GetMonMyPrice(prd, _supplier, _group, _token);
            }
            catch (System.Exception)
            {
                itemreq = null;
            }
            ViewBag.Prd = prd;
            return PartialView("_AjaxGetMonMyPrice", itemreq);
        }

        public async Task<IActionResult> DownloadMyPrice(string prd)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                var queryString = "?prd=" + prd + "&sup=" + _supplier + "&group=" + _group;
                var uri = ApiClientFactory.Instance.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/DownloadMyPrice"), queryString);
                var response = await _httpClient.GetAsync(uri.ToString());

                string contentType = "application/pdf";
                //Define the file name
                string fileName = "PPH_MyPrice_" + DateTime.Now + ".pdf";

                if (response.IsSuccessStatusCode)
                {
                    System.Net.Http.HttpContent content = response.Content;
                    var contentStream = await content.ReadAsStreamAsync(); // get the actual content stream
                    return File(contentStream, contentType, fileName);
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