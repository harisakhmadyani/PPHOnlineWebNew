using System.Collections.Generic;
using System.Threading.Tasks;
using PlgRequest.Models;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<ItemRequest> GetProductItem(string id, string sup, string group, string token){
            var queryString = "?id=" + id + "&sup=" + sup + "&group=" + group;
            var uri = "Plg/GetProductItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        // public async Task<ItemRequest> GetMyProductItem(string sup, string group, string token){
        //     var queryString = "?sup=" + sup + "&group=" + group;
        //     var uri = "Plg/GetMyProductItem";
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
        //     var hasil = await GetAsync<ItemRequest>(requestUrl, token);
        //     return hasil;
        // }

        public async Task<ItemRequest> GetMyProductItem(string sup, string group, int pages, string token){
            var queryString = "?sup=" + sup + "&group=" + group + "&pages=" + pages;
            var uri = "Plg/GetMyProductItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        public async Task<CountData> GetCountMyProductItem(string sup, string token){
            var queryString = "?sup=" + sup;
            var uri = "Plg/GetCountMyProductItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<CountData>(requestUrl, token);
            return hasil;
        }

        public async Task<ItemRequest> GetMyPrice(string sup, string group, string token){
            var queryString = "?sup=" + sup + "&group=" + group;
            var uri = "Plg/GetMyPrice";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        public async Task<ItemRequest> GetNewProductItem(string sup, string group, string token){
            var queryString = "?sup=" + sup + "&group=" + group;
            var uri = "Plg/GetNewProductItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        public async Task<StAction> SimpanPrice(InputPrice inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SavePrice"));
            return await PostAsync2<StAction, InputPrice>(requestUrl, inp, token);
        }
        
        public async Task<StAction> UpdatePrice(InputPrice inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/UpdatePrice"));
            return await PostAsync2<StAction, InputPrice>(requestUrl, inp, token);
        }

        public async Task<ItemRequest> GetMonMyPrice(string prd, string sup, string group, string token){
            var queryString = "?prd=" + prd + "&sup=" + sup + "&group=" + group;
            var uri = "Plg/GetMonMyPrice";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }
    }
}