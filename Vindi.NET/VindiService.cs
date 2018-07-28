using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vindi.NET.Model;

namespace Vindi.NET
{
    public class VindiService
    {
        private string _urlApi;
        private object _authorization;

        public VindiService(VindiConfiguration config)
        {
            _urlApi = $@"{config.UrlApi}/api/v{config.Version}";
            _authorization = config.Authorization;
        }

        public async Task<IEnumerable<Customer>> GetCustomersByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("customers", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Customer>>(list?.customers);
        }

        public async Task<IEnumerable<Plan>> GetPlansByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("plans", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Plan>>(list?.plans);
        }

        public async Task<IEnumerable<Product>> GetProductsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("products", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Product>>(list?.products);
        }

        public async Task<IEnumerable<Payment_Methods>> GetPaymentMethoidsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("payment_methods", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Payment_Methods>>(list?.payment_methods);
        }

        public async Task<IEnumerable<Subscription>> GetSubscriptionsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("subscriptions", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Subscription>>(list?.subscriptions);
        }

        public async Task<IEnumerable<Period>> GetPeriodsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("periods", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Period>>(list?.periods);
        }

        public async Task<IEnumerable<Bill>> GetBillsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("bills", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Bill>>(list?.bills);
        }

        public async Task<IEnumerable<Charge>> GetChargesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.created_at, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("charges", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Charge>>(list?.charges);
        }

        public async Task<IEnumerable<Invoice>> GetInvoicesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("invoices", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Invoice>>(list?.invoices);
        }

        public async Task<IEnumerable<Message>> GetMessagesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("messages", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Message>>(list?.messages);
        }

        public async Task<IEnumerable<Import_Batche>> GetImportBatchesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("import_batches", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Import_Batche>>(list?.import_batches);
        }

        public async Task<IEnumerable<Issue>> GetIssuesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("issues", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Issue>>(list?.issues);
        }

        public async Task<IEnumerable<Notification>> GetNotificationsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("notifications", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Notification>>(list?.notifications);
        }

        public async Task<IEnumerable<Merchant>> GetMerchantsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("merchants", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Merchant>>(list?.merchants);
        }

        public async Task<IEnumerable<Merchant_Users>> GetMerchantUsersByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("merchant_users", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Merchant_Users>>(list?.merchant_users);
        }

        public async Task<IEnumerable<Role>> GetRolesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await SearchByAnythingAsync("roles", query = null, page, perPage, filterSearch, sortOrder);
            return FromDynamic<IEnumerable<Role>>(list?.roles);
        }

        public async Task<dynamic> GetCustomersByIdAsync(int id)
        {
            return await SearchByIdAsync("customers", id);
        }

        public async Task<dynamic> GetPlansByIdAsync(int id)
        {
            return await SearchByIdAsync("plans", id); 
        }

        public async Task<dynamic> GetProductsByIdAsync(int id)
        {
            return await SearchByIdAsync("products", id);
        }

        public async Task<dynamic> GetPaymentMethoidsByIdAsync(int id)
        {
            return await SearchByIdAsync("payment_methods", id);
        }

        public async Task<dynamic> GetSubscriptionsByIdAsync(int id)
        {
            return await SearchByIdAsync("subscriptions", id);
        }

        public async Task<dynamic> GetPeriodsByIdAsync(int id)
        {
            return await SearchByIdAsync("periods", id);
        }

        public async Task<dynamic> GetBillsByIdAsync(int id)
        {
            return await SearchByIdAsync("bills", id);
        }

        public async Task<dynamic> GetChargesByIdAsync(int id)
        {
            return await SearchByIdAsync("charges", id);
        }

        public async Task<dynamic> GetInvoicesByIdAsync(int id)
        {
            return await SearchByIdAsync("invoices", id);
        }

        public async Task<dynamic> GetMessagesByIdAsync(int id)
        {
            return await SearchByIdAsync("messages", id);
        }

        public async Task<dynamic> GetImportBatchesByIdAsync(int id)
        {
            return await SearchByIdAsync("import_batches", id);
        }

        public async Task<dynamic> GetIssuesByIdAsync(int id)
        {
            return await SearchByIdAsync("issues", id);
        }

        public async Task<dynamic> GetNotificationsByIdAsync(int id)
        {
            return await SearchByIdAsync("notifications", id);
        }

        public async Task<dynamic> GetMerchantsByIdAsync(int id)
        {
            return await SearchByIdAsync("merchants", id);
        }

        public async Task<dynamic> GetMerchantUsersByIdAsync(int id)
        {
            return await SearchByIdAsync("merchant_users", id);
        }

        public async Task<dynamic> GetRolesByIdAsync(int id)
        {
            return await SearchByIdAsync("roles", id);
        }



        private async Task<dynamic> SearchByAnythingAsync(string uri, IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
            => await $@"{_urlApi}/{uri}?page={page}&per_page={perPage}&sort_by={filterSearch.ToString()}&sort_order={sortOrder.ToString()}{VindiQueryString(query)}"
                .WithHeaders(new { Authorization = _authorization })
                .GetJsonAsync();

        private async Task<dynamic> SearchByIdAsync(string uri, int id) 
            => await $@"{_urlApi}/{uri}/{id}"
                .WithHeaders(new { Authorization = _authorization })
                .GetJsonAsync();


        private static T FromDynamic<T>(dynamic d) where T : class
        {
            var p = JsonConvert.SerializeObject(d);
            if (p.StartsWith("["))
                return JArray.Parse(p).ToObject<T>();

            return JObject.Parse(p).ToObject<T>();
        }

        private static string VindiQueryString(IDictionary<FilterSearch, string> query)
            => query != null ? $"&query={string.Join(" ", query.Select(x => $"{x.Key}:{x.Value}"))}" : string.Empty;
    }
}