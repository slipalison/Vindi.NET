using System;

namespace Vindi.NET.Model
{
    public class Payment_Profile
    {
        public int id { get; set; }
        public string holder_name { get; set; }
        public object registry_code { get; set; }
        public object bank_branch { get; set; }
        public object bank_account { get; set; }
        public DateTime? card_expiration { get; set; }
        public string card_number_first_six { get; set; }
        public string card_number_last_four { get; set; }
        public string token { get; set; }
        public DateTime? created_at { get; set; }
        public Payment_Company payment_company { get; set; }
    }
}
