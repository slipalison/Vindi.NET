using System;

namespace Vindi.NET.Model
{

    public class Bill
    {
        public int id { get; set; }
        public object code { get; set; }
        public string amount { get; set; }
        public int installments { get; set; }
        public string status { get; set; }
        public object seen_at { get; set; }
        public object billing_at { get; set; }
        public DateTime? due_at { get; set; }
        public string url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Bill_Items[] bill_items { get; set; }
        public Charge[] charges { get; set; }
        public Customer customer { get; set; }
        public Period period { get; set; }
        public Subscription subscription { get; set; }
        public object metadata { get; set; }
        public object payment_profile { get; set; }
        public object payment_condition { get; set; }
    }

}
