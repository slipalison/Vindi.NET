using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<dynamic> GetCustomersByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("customers", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetPlansByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("plans", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetProductsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("products", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetPaymentMethoidsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("payment_methods", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetSubscriptionsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("subscriptions", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetPeriodsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("periods", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetBillsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("bills", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetChargesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("charges", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetInvoicesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("invoices", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetMessagesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("messages", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetImportBatchesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("import_batches", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetIssuesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("issues", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }
        
        public async Task<dynamic> GetNotificationsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("notifications", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }
        
        public async Task<dynamic> GetMerchantsByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("merchants", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetMerchantUsersByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("merchant_users", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetRolesByAnythingAsync(IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
        {
            var list = await Search("roles", query = null, page, perPage, filterSearch, sortOrder);
            return list;
        }

        public async Task<dynamic> GetCustomersByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/customers/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetPlansByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/plans/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetProductsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/products/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetPaymentMethoidsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/payment_methods/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetSubscriptionsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/subscriptions/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetPeriodsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/periods/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetBillsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/bills/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetChargesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/charges/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetInvoicesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/invoices/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetMessagesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/messages/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetImportBatchesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/import_batches/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetIssuesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/issues/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetNotificationsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/notifications/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetMerchantsByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/merchants/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetMerchantUsersByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/merchant_users/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }

        public async Task<dynamic> GetRolesByIdAsync(int id)
        {
            var list = await $@"{_urlApi}/roles/{id}".WithHeaders(new { Authorization = _authorization }).GetJsonAsync();
            return list;
        }



        private async Task<dynamic> Search(string uri, IDictionary<FilterSearch, string> query = null, int page = 1, int perPage = 20, FilterSearch filterSearch = FilterSearch.id, SortOrder sortOrder = SortOrder.asc)
            => await $@"{_urlApi}/{uri}?page={page}&per_page={perPage}&sort_by={filterSearch.ToString()}&sort_order={sortOrder.ToString()}{VindiQueryString(query)}"
                .WithHeaders(new { Authorization = _authorization })
                .GetJsonAsync();

        private static T FromDynamic<T>(dynamic d) where T : class => (T)Convert.ChangeType(d, typeof(T));

        private static string VindiQueryString(IDictionary<FilterSearch, string> query)
            => query != null ? $"&query={string.Join(" ", query.Select(x => $"{x.Key}:{x.Value}"))}" : string.Empty;
    }
}