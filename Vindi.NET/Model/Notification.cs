using System;

namespace Vindi.NET.Model
{
    public class Notification
    {
        public int id { get; set; }
        public string status { get; set; }
        public string notification_type { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public string content { get; set; }
        public string trigger_type { get; set; }
        public int trigger_day { get; set; }
        public object bcc { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
