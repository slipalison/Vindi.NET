using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Payment_Methods
    {
        public int id { get; set; }
        public string public_name { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public Settings settings { get; set; }
        public string set_subscription_on_success { get; set; }
        public bool allow_as_alternative { get; set; }
        public Payment_Companies[] payment_companies { get; set; }
        public int? maximum_attempts { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
