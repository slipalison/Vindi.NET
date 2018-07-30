using System;

namespace Vindi.NET.Model
{
    public class Message
    {
        public int id { get; set; }
        public string notification_type { get; set; }
        public object seen_at { get; set; }
        public DateTime? created_at { get; set; }
        public Customer customer { get; set; }
        public Charge charge { get; set; }
        public Notification notification { get; set; }
    }
}
