using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Settings
    {
        public bool automatic_bill_charge { get; set; }
        public object due_days { get; set; }
        public bool require_gateway { get; set; }
        public string bank_slip_type { get; set; }
        public string branch { get; set; }
        public string format { get; set; }
        public string additional_instructions { get; set; }
        public string account { get; set; }
        public string contract_number { get; set; }
        public string payment_company_id { get; set; }
        public bool dynamic { get; set; }
        public bool require_registration { get; set; }
        public bool defer_registration { get; set; }
        public string document_type { get; set; }
        public bool voidable { get; set; }
    }

}
