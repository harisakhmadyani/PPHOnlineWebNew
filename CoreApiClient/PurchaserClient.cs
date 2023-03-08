using System.Threading.Tasks;
using PlgRequest.Models;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<ItemRequest> GetPriceItem(string sub, string group, string factAbbr, string token){
            var queryString = "?sub=" + sub +"&group=" + group +"&factAbbr=" + factAbbr;
            var uri = "Plg/GetPriceItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }
        
        public async Task SimpanPrice(ImportToPPH inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveToPPH"));
            await PostAsync1<ImportToPPH>(requestUrl, inp, token);
        }

        public async Task<StAction> SimpanPrice2(ImportToPPH inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveToPPH"));
            return await PostAsync2<StAction, ImportToPPH>(requestUrl, inp, token);
        }

        public async Task<ItemRequest> GetPriceNewItem(string factAbbr, string token){
            var queryString = "?factAbbr=" + factAbbr;
            var uri = "Plg/GetPriceNewItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        public async Task<StAction> UpdatePriceNewItem(UpdateToNewItem inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/UpdateToNewItem"));
            return await PostAsync2<StAction, UpdateToNewItem>(requestUrl, inp, token);
        }

    }
}