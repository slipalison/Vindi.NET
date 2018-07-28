namespace Vindi.NET.Model
{
    public class Issue
    {
        public int id { get; set; }
        public string issue_type { get; set; }
        public string status { get; set; }
        public string item_type { get; set; }
        public string item_id { get; set; }
        public string data { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public Customer customer { get; set; }
    }
}
