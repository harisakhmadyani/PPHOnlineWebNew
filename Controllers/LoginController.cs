using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PlgRequest.Data;
using PlgRequest.Factory;
using PlgRequest.Models;
using PlgRequest.Utility;
using System.IdentityModel.Tokens.Jwt;
using Telegram.Bot;

namespace PlgRequest.Controllers
{
    // [SesionLogin]
    public class LoginController : Controller
    {
        const string SessionToken = "_Tokens";
        const string SessionUser = "_Users";
        const string SessionUserName = "_UserNames";
        const string SessionConnect = "_Cos";
        const string SessionUId = "_UIds";
        const string SessionRole = "_Roles";
        const string SessionHaveGA = "_GAs";
        const string SessionLoginWITHGA = "_AuthGAs";
        const string SessionSecretKey = "_Secrets";
        const string SessionFac = "_Facs";
        const string SessionFacAbbr = "_FAbbrs";
        const string SessionDept = "_Depts";
        const string SessionGroup = "_Groups";
        const string SessionTelegram = "_Telegrams";
        const string SessionTelegramKode = "_Kode";
        const string SessionSup = "_Supplier";        
        // private bool _val =;
        private readonly IOptions<MySetting> appSettings;
        private bool _val;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;
        private ISession _sesion => _httpContextAccessor.HttpContext.Session;
        public static ITelegramBotClient botClient;
        public string random;

        public LoginController(IOptions<MySetting> app, IHttpContextAccessor httpContextAccessor, IConfiguration config)
        {
            botClient = new TelegramBotClient("1328285826:AAFFfhxwJswKuqTQeelmpsOAh8TZngy86aw");
            appSettings = app;
             _val = IsInetConected();
            if(_val){
                ApplicationSettings.webApiUrl = appSettings.Value.WebApiBaseUrl; // "http://localhost:5006/Doc.Api/"; 
            }else{
                ApplicationSettings.webApiUrl = appSettings.Value.WebApiBaseUrlOnline; // "http://localhost:5006/Doc.Api/"; 
            }
            // ApplicationSettings.webApiUrl = appSettings.Value.WebApiBaseUrlOnline; // "http://localhost:5006/Doc.Api/"; 
            _httpContextAccessor = httpContextAccessor;
            _config = config;
        }

        private bool IsInetConected()
        {
            string url = "http://192.168.12.168:5008/apimyrsup/GetStatusOnline";
            // string url = "http://localhost:5002/api/Values";
            try
            {
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();
            }
            catch (System.Net.WebException e)
            {
                var a = e.Message;
                return false;
            }
            return true;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Auth()
        {
            if (_sesion.GetString("_Secrets") is null)
                return RedirectToAction("Index", "Login");
            else
            {
                var a = RandomPassword();

                _sesion.SetString(SessionTelegramKode, a);

                botClient.SendTextMessageAsync(
                    chatId: _sesion.GetString("_Telegrams"),
                    text: "Your OTP is : " + a
                );

                return View();
            }

        }

        public async Task<IActionResult> CekLogin(UserForLoginDto userForLoginDto)
        {
            try
            {
                var response = await ApiClientFactory.Instance.CekLogin(userForLoginDto);
                DeserializeJwt _getJwt = GetDeserializeJwt(response.Token);
                var _role = _getJwt.Role;
                var _UID = _getJwt.UID;
                var _Uname = _getJwt.UName;
                _sesion.SetString(SessionToken, response.Token);
                _sesion.SetString(SessionUser, response.user.userId);
                _sesion.SetString(SessionUserName, _Uname);
                _sesion.SetString(SessionRole, _role);
                _sesion.SetString(SessionUId, _UID);
                _sesion.SetString(SessionHaveGA, response.user.HaveGA.ToString());
                _sesion.SetString(SessionSecretKey, response.user.SecretKey);
                _sesion.SetString(SessionFac, response.user.Factory.ToString());
                _sesion.SetString(SessionFacAbbr, response.user.FacAbbr);
                _sesion.SetString(SessionDept, response.user.Dept);
                _sesion.SetString(SessionGroup, response.user.GroupAccess);
                _sesion.SetString(SessionTelegram, response.user.TelegramID);
                _sesion.SetString(SessionSup, response.user.SupplierID);
                if (_val)
                {
                    _sesion.SetString(SessionConnect, "Local");
                }
                else
                {
                    _sesion.SetString(SessionConnect, "Web");
                }

                // return RedirectToAction("Auth", "Login");
                var kode = _sesion.GetString("_Kode");
                this._sesion.SetString("_AuthGAs", "true");
                return Ok(new{msg = "ok"});
            }
            catch (SystemException e)
            {
                _sesion.Clear();
                // return RedirectToAction("Index", "Login", new { status = "gagallogin" + e.Message });
                return Ok(new{msg = "not", msg2 = e.Message});
            }
        }       

        private DeserializeJwt GetDeserializeJwt(string token)
        {
            DeserializeJwt deserialize = new DeserializeJwt();
            string secret = _config.GetSection("AppSettings:Token").Value;
            var key = Encoding.ASCII.GetBytes(secret);
            var handler = new JwtSecurityTokenHandler();
            var tokenSecure = handler.ReadToken(token) as JwtSecurityToken;
            deserialize.Role = tokenSecure.Payload["role"].ToString();
            deserialize.UID = tokenSecure.Payload["nameid"].ToString();
            deserialize.UName = tokenSecure.Payload["unique_name"].ToString();
            return deserialize;
        }

        // public async Task<IActionResult> ChangePassword(ChangePassword changePassword)
        // {
        //     string _token = _sesion.GetString("_Tokens");
        //     changePassword.UserId = _sesion.GetString("_Users");
        //     await ApiClientFactory.Instance.ChangePassword(changePassword, _token);
        //     return Ok(new { msg = "ok" });
        // }

        public IActionResult Check2FA(string input)
        {
            string t2fa = input;
            var kode = _sesion.GetString("_Kode");
            if(t2fa == "1"){
                this._sesion.SetString("_AuthGAs", "true");
                return Ok(new{msg = "ok"});
            }else{
                return Ok(new{msg = "not"});
            }            
        }
               
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            // passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(100000, 999999));

            // 2-Letters upper case  
            // passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }

        public async Task<IActionResult> AjaxSaveChangePassword(ChangePasswordDto i){
            string  _token = _sesion.GetString("_Tokens");
            ChangePassword inp = new ChangePassword();
            try
            {
                inp.OldPassword = i.oldPassword;
                inp.NewPassword = i.newPassword;
                inp.UserId = _sesion.GetString("_Users");

                await ApiClientFactory.Instance.SimpanChangePassword(inp, _token);
                return Ok(new { msg = "ok" });
            }
            catch (System.Exception)
            {
                return Ok(new { msg = "not" });
            }
        }

        public IActionResult LogOut(){
            _sesion.Clear();
            return RedirectToAction("Index", "Login");
            // return View();
        }            
    }
}