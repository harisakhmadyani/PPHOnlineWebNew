using System.Threading.Tasks;
using PlgRequest.Models;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {
        public async Task SimpanRoleDateTime(RoleDateTime inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveRoleDateTime"));
            await PostAsync1<RoleDateTime>(requestUrl, inp, token);
        }

        public async Task<DateTimeNow> GetDateTimeNow(string token){
            var uri = "Plg/GetDateTimeNow";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<DateTimeNow>(requestUrl, token);
            return hasil;
        }

        public async Task<RoleDateTime> GetLastRoleDateTime(string token){
            var uri = "Plg/GetLastRoleDateTime0";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<RoleDateTime>(requestUrl, token);
            return hasil;
        }

        public async Task SimpanBudgetPeriod(BudgetPeriod inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveBudgetPeriod"));
            await PostAsync1<BudgetPeriod>(requestUrl, inp, token);
        }

        public async Task<BudgetPeriod> GetLastBudgetPeriod(string token){
            var uri = "Plg/GetLastBudgetPeriod";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri));
            var hasil = await GetAsync<BudgetPeriod>(requestUrl, token);
            return hasil;
        }

        public async Task<SubCategory> GetSubCategory(string group, string token){
            var queryString = "?group=" + group;
            var uri = "Plg/GetSubCategory";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<SubCategory>(requestUrl, token);
            return hasil;
        }

        public async Task<Currency> GetCurrency(string group, string token){
            var queryString = "?group=" + group;
            var uri = "Plg/GetCurrency";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<Currency>(requestUrl, token);
            return hasil;
        }

        // public async Task<ItemSupplier> GetMyItem(string sup, string group, string token){
        //     var queryString = "?sup=" + sup + "&group=" + group;
        //     var uri = "Plg/GetMyItem";
        //     var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
        //     var hasil = await GetAsync<ItemSupplier>(requestUrl, token);
        //     return hasil;
        // }

        public async Task<ItemSupplier> GetMyItem(string sup, string group, int pages, string token){
            var queryString = "?sup=" + sup + "&group=" + group + "&pages=" + pages;
            var uri = "Plg/GetMyItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemSupplier>(requestUrl, token);
            return hasil;
        }

        public async Task<CountData> GetCountMyItem(string sup, string token){
            var queryString = "?sup=" + sup;
            var uri = "Plg/GetCountMyItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<CountData>(requestUrl, token);
            return hasil;
        }

        public async Task<ItemRequest> GetChooseMyItem(string id, string sup, string group, string token){
            var queryString = "?id=" + id + "&sup=" + sup + "&group=" + group;
            var uri = "Plg/GetChooseMyItem";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }

        public async Task<StAction> SimpanMyItem(InputMyItem inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/SaveMyItem"));
            return await PostAsync2<StAction, InputMyItem>(requestUrl, inp, token);
        }

        public async Task<StAction> RemoveMyItem(InputMyItem inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/RemoveMyItem"));
            return await PostAsync2<StAction, InputMyItem>(requestUrl, inp, token);
        }

        public async Task RefreshItemOpenPrice(ItemOpenPrice inp, string token){
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,"Plg/RefreshItemOpenPrice"));
            await PostAsync1<ItemOpenPrice>(requestUrl, inp, token);
        }

        public async Task<ItemRequest> GetItemOpenPrice(string subCat, string factAbbr, string token){
            var queryString = "?subCat=" + subCat + "&factAbbr=" + factAbbr;
            var uri = "Plg/GetItemOpenPrice";
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, uri), queryString);
            var hasil = await GetAsync<ItemRequest>(requestUrl, token);
            return hasil;
        }
    }
}