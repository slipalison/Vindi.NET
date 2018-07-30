using Vindi.NET.Model;

namespace Vindi.NET.Requesters
{
    public class SubscriptionRequester
    {
        public int plan_id { get; set; }
        public int customer_id { get; set; }
        public string payment_method_code { get; set; }
        public Product_Items[] product_items { get; set; }
    }
}
