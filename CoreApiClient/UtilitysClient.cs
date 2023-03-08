using System.Collections.Generic;
using System.Threading.Tasks;
using PlgRequest.Models;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {   
        public async Task<IEnumerable<MenuHdr>> GetMenuHdr(string group, string token){
            var queryString = "?group=" + group;
            var uri = "Plg/GetMenuHdr";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync2<MenuHdr>(requestUrl, token);
            return hasil;
        }

        public async Task<IEnumerable<MenuDtl>> GetMenuDtl(string group, string token){
            var queryString = "?group=" + group;
            var uri = "Plg/GetMenuDtl";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync2<MenuDtl>(requestUrl, token);
            return hasil;
        }
        
        public async Task<RoleDateTime> GetLastRoleDateTimeWidget1(string token){
            var uri = "Plg/GetLastRoleDateTime1";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<RoleDateTime>(requestUrl, token);
            return hasil;
        }

        public async Task<RoleDateTime> GetLastRoleDateTimeWidget2(string token){
            var uri = "Plg/GetLastRoleDateTime2";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<RoleDateTime>(requestUrl, token);
            return hasil;
        }

        public async Task<GroupAccess> GetGroupAccess(string token){
            var uri = "Plg/GetGroupAccess";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<GroupAccess>(requestUrl, token);
            return hasil;
        }

        public async Task<GroupAccess> GetGroupAccessByID(string groupAccessID, string token){
            var uri = "Plg/GetGroupAccessByID?id="+ groupAccessID;
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<GroupAccess>(requestUrl, token);
            return hasil;
        }

        public async Task SimpanGroupAccess(InputGroupAccess inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveGroupAccess"));
            await PostAsync1<InputGroupAccess>(requestUrl, inp, token);
        }

        public async Task UpdateGroupAccess(InputGroupAccess inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/UpdateGroupAccess"));
            await PostAsync1<InputGroupAccess>(requestUrl, inp, token);
        }

        public async Task DeleteGroupAccess(InputGroupAccess inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/DeleteGroupAccess"));
            await PostAsync1<InputGroupAccess>(requestUrl, inp, token);
        }

        public async Task<IEnumerable<MenuHdr>> GetAllMenuHdr(string token){
            var uri = "Plg/GetAllMenuHdr";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync2<MenuHdr>(requestUrl, token);
            return hasil;
        }

        public async Task<IEnumerable<MenuDtl>> GetAllMenuDtl(string token){
            var uri = "Plg/GetAllMenuDtl";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync2<MenuDtl>(requestUrl, token);
            return hasil;
        }            
    }    
}