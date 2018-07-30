using System;

namespace Vindi.NET.Model
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string registry_code { get; set; }
        public string code { get; set; }
        public string notes { get; set; }
        public string status { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public object metadata { get; set; }
        public Address address { get; set; }
        public Phone[] phones { get; set; }
    }
}
