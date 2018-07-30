using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Plan_Items
    {
        public int id { get; set; }
        public Product product { get; set; }
        public object cycles { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
