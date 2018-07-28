using System;

namespace Vindi.NET.Model
{
    public class Pricing_Schema
    {
        public int id { get; set; }
        public string short_format { get; set; }
        public string price { get; set; }
        public object minimum_price { get; set; }
        public string schema_type { get; set; }
        public object[] pricing_ranges { get; set; }
        public DateTime created_at { get; set; }
    }

}
