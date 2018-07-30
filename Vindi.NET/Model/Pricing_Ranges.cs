using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Pricing_Ranges
    {
        public string id { get; set; }
        public int start_quantity { get; set; }
        public int end_quantity { get; set; }
        public int price { get; set; }
        public int overage_price { get; set; }
    }
}
