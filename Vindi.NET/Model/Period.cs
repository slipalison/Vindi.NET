using System;

namespace Vindi.NET.Model
{
    public class Period
    {
        public int id { get; set; }
        public DateTime billing_at { get; set; }
        public int cycle { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public int duration { get; set; }
        public Subscription subscription { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
