using System;

namespace Vindi.NET.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new VindiConfiguration("https://app.vindi.com.br", 1, "Basic Z1UxeWozLWNwaUtINVpQNnNtOXBESkxkUjNWOUJNU25ubU1Pd3hsWFBkaw==");

            var service = new VindiService(config);
           
            var customers = service.GetCustomersByAnythingAsync().GetAwaiter().GetResult();
            var plans = service.GetPlansByAnythingAsync().GetAwaiter().GetResult();
            var products = service.GetProductsByAnythingAsync().GetAwaiter().GetResult();
            var paymentMethods = service.GetPaymentMethoidsByAnythingAsync().GetAwaiter().GetResult();
            var subscriptions = service.GetSubscriptionsByAnythingAsync().GetAwaiter().GetResult();
            var bills = service.GetBillsByAnythingAsync().GetAwaiter().GetResult();
            var charges = service.GetChargesByAnythingAsync().GetAwaiter().GetResult();
            var invoices = service.GetInvoicesByAnythingAsync().GetAwaiter().GetResult();
            var messages = service.GetMessagesByAnythingAsync().GetAwaiter().GetResult();
            var importBatches = service.GetImportBatchesByAnythingAsync().GetAwaiter().GetResult();
            var issues = service.GetIssuesByAnythingAsync().GetAwaiter().GetResult();
            var notifications = service.GetNotificationsByAnythingAsync().GetAwaiter().GetResult();
            var merchant_Users = service.GetMerchantUsersByAnythingAsync().GetAwaiter().GetResult();
            var roles = service.GetRolesByAnythingAsync().GetAwaiter().GetResult();

            Console.WriteLine("Hello World!");
        }
    }
}
