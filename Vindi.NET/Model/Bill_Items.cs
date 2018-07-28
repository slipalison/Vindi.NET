namespace Vindi.NET.Model
{
    public class Bill_Items
    {
        public int id { get; set; }
        public string amount { get; set; }
        public int quantity { get; set; }
        public object pricing_range_id { get; set; }
        public object description { get; set; }
        public Pricing_Schema pricing_schema { get; set; }
        public Product product { get; set; }
        public Product_Items product_item { get; set; }
        public object discount { get; set; }
    }
}
