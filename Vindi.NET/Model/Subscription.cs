using System;

namespace Vindi.NET.Model
{
    public class Subscription
    {
        public int id { get; set; }
        public string status { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public object next_billing_at { get; set; }
        public object overdue_since { get; set; }
        public string code { get; set; }
        public DateTime cancel_at { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public string billing_trigger_type { get; set; }
        public int billing_trigger_day { get; set; }
        public object billing_cycles { get; set; }
        public int installments { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Customer customer { get; set; }
        public Plan plan { get; set; }
        public Product_Items[] product_items { get; set; }
        public Payment_Method payment_method { get; set; }
        public object current_period { get; set; }
        public object metadata { get; set; }
        public object payment_profile { get; set; }
    }
}
