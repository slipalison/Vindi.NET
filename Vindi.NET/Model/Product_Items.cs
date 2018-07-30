using System;

namespace Vindi.NET.Model
{
    public class Product_Items
    {
        public int id { get; set; }
        public int? product_id { get; set; }
        public string status { get; set; }
        public object cycles { get; set; }
        public int? quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Product product { get; set; }
        public Pricing_Schema pricing_schema { get; set; }
        public object[] discounts { get; set; }
    }
}
