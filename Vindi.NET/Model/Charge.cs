using System;

namespace Vindi.NET.Model
{
    public class Charge
    {
        public int id { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
        public DateTime? due_at { get; set; }
        public DateTime? paid_at { get; set; }
        public int? installments { get; set; }
        public int? attempt_count { get; set; }
        public object next_attempt { get; set; }
        public object print_url { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public Last_Transaction last_transaction { get; set; }
        public Payment_Methods payment_method { get; set; }
        public Bill bill { get; set; }
        public Customer customer { get; set; }
    }
}
