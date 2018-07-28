using System;

namespace Vindi.NET.Model
{
    public class Plan
    {
        public int id { get; set; }
        public string name { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public string billing_trigger_type { get; set; }
        public int billing_trigger_day { get; set; }
        public int? billing_cycles { get; set; }
        public object code { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public int installments { get; set; }
        public bool invoice_split { get; set; }
        public string interval_name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Plan_Items[] plan_items { get; set; }
        public Object metadata { get; set; }
    }
}
