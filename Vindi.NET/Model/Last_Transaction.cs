using System;

namespace Vindi.NET.Model
{
    public class Last_Transaction
    {
        public int id { get; set; }
        public string transaction_type { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        public int? installments { get; set; }
        public string gateway_message { get; set; }
        public object gateway_response_code { get; set; }
        public string gateway_authorization { get; set; }
        public string gateway_transaction_id { get; set; }
        public Gateway_Response_Fields gateway_response_fields { get; set; }
        public object fraud_detector_score { get; set; }
        public object fraud_detector_status { get; set; }
        public object fraud_detector_id { get; set; }
        public DateTime created_at { get; set; }
        public Gateway gateway { get; set; }
        public Payment_Profile payment_profile { get; set; }
    }
}
