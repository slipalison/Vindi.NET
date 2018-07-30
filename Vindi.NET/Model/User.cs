using System;

namespace Vindi.NET.Model
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public DateTime? created_at { get; set; }
    }
}
