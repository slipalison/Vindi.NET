using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Discount
    {
        public int id { get; set; }
        public string discount_type { get; set; }
        public int percentage { get; set; }
        public int amount { get; set; }
        public int quantity { get; set; }
        public int cycles { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public Product_Items product_item { get; set; }
    }

}
