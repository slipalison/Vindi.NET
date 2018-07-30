using System;

namespace Vindi.NET.Model
{
    public class Current_Period
    {
        public int id { get; set; }
        public DateTime billing_at { get; set; }
        public int cycle { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public int? duration { get; set; }
    }
}
