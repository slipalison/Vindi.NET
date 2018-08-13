using Vindi.NET.Model;


namespace Vindi.NET.Requesters
{
    public class CreateProductItemRequester
    {
        public int product_id { get; set; }
        public int subscription_id { get; set; }
        public int cycles { get; set; }
        public int quantity { get; set; }
        public Pricing_Schema pricing_schema { get; set; }
    }


}
