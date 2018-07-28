using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public async Task<Customer> GetCustomersByIdAsync(int id)
        {
            var result = await SearchByIdAsync("customers", id);
            return FromDynamic<Customer>(result?.customer);
        }

        public async Task<Plan> GetPlansByIdAsync(int id)
        {
            var result = await SearchByIdAsync("plans", id);
            return FromDynamic<Plan>(result?.plan);
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("products", id);
            return FromDynamic<Product>(result?.product);
        }

        public async Task<Payment_Method> GetPaymentMethoidsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("payment_methods", id);
            return FromDynamic<Payment_Method>(result?.payment_method);
        }

        public async Task<Subscription> GetSubscriptionsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("subscriptions", id);
            return FromDynamic<Subscription>(result?.subscription);
        }

        public async Task<Period> GetPeriodsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("periods", id);
            return FromDynamic<Period>(result?.period);
        }

        public async Task<Bill> GetBillsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("bills", id);
            return FromDynamic<Bill>(result?.bill);
        }

        public async Task<Charge> GetChargesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("charges", id);
            return FromDynamic<Charge>(result?.charge);
        }

        public async Task<Invoice> GetInvoicesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("invoices", id);
            return FromDynamic<Invoice>(result?.invoice);
        }

        public async Task<Message> GetMessagesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("messages", id);
            return FromDynamic<Message>(result?.message);
        }

        public async Task<Import_Batche> GetImportBatchesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("import_batches", id);
            return FromDynamic<Import_Batche>(result?.import_batche);
        }

        public async Task<Issue> GetIssuesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("issues", id);
            return FromDynamic<Issue>(result?.issue);
        }

        public async Task<Notification> GetNotificationsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("notifications", id);
            return FromDynamic<Notification>(result?.notification);
        }

        public async Task<Merchant> GetMerchantsByIdAsync(int id)
        {
            var result = await SearchByIdAsync("merchants", id);
            return FromDynamic<Merchant>(result?.merchant);
        }

        public async Task<Merchant_Users> GetMerchantUsersByIdAsync(int id)
        {
            var result = await SearchByIdAsync("merchant_users", id);
            return FromDynamic<Merchant_Users>(result?.merchant_user);
        }

        public async Task<Role> GetRolesByIdAsync(int id)
        {
            var result = await SearchByIdAsync("roles", id);
            return FromDynamic<Role>(result?.role);
        }

        public async Task<Discount> GetDiscountByIdAsync(int id)
        {
            var result = await SearchByIdAsync("discounts", id);
            return FromDynamic<Discount>(result?.discount);
        }

        public async Task<Product_Items> GetProductItemByIdAsync(int id)
        {
            var result = await SearchByIdAsync("product_items", id);
            return FromDynamic<Product_Items>(result?.product_item);
        }

        public async Task<Bill_Items> GetBillItemByIdAsync(int id)
        {
            var result = await SearchByIdAsync("bill_items", id);
            return FromDynamic<Bill_Items>(result?.bill_item);
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
            => query != null ? $"&query={string.Join(" ", query.Select(x => $"{x.Key.ToString()}:{x.Value}"))}" : string.Empty;
    }
}