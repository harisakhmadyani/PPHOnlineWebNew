using System.Collections.Generic;
using System.Threading.Tasks;
using PlgRequest.Models;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<UserForLoginDataDto> CekLogin(UserForLoginDto userForLoginDto){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Auth/login"));
            return await PostAsync2<UserForLoginDataDto, UserForLoginDto>(requestUrl, userForLoginDto);
        }

        public async Task SimpanChangePassword(ChangePassword inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveChangePassword"));
            await PostAsync1<ChangePassword>(requestUrl, inp, token);
        }

        // public async Task ChangePassword(ChangePassword changePassword, string token){
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Auth/ChangePassword"));
        //     await PostAsync1<ChangePassword>(requestUrl, changePassword, token);
        // }

        // public async Task<AuthReg> RegisterGA(AuthReg pin, string token){
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Auth/RegisterGA"));
        //     var hasil = await PostAsync2<AuthReg>(requestUrl, pin, token);
        //     return hasil;
        // }
        
        // public async Task<IEnumerable<MenuHdr>> GetMenuHdr(string group, string token){
        //     var queryString = "?group=" + group;
        //     var uri = "Auth/GetMenuHdr";
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
        //     var hasil = await GetAsync2<MenuHdr>(requestUrl, token);
        //     return hasil;
        // }

        // public async Task<IEnumerable<MenuDtl>> GetMenuDtl(string group, string token){
        //     var queryString = "?group=" + group;
        //     var uri = "Auth/GetMenuDtl";
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
        //     var hasil = await GetAsync2<MenuDtl>(requestUrl, token);
        //     return hasil;
        // }
    }

}