using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Invoice
    {
        public int id { get; set; }
        public decimal? amount { get; set; }
        public string status { get; set; }
        public string integration_invoice_id { get; set; }
        public string integration_reference { get; set; }
        public string print_url { get; set; }
        public string description { get; set; }
        public string settings { get; set; }
        public DateTime? issued_at { get; set; }
        public DateTime? scheduled_at { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public Bill bill { get; set; }
        public Customer customer { get; set; }
    }
}
