using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Merchant_Users
    {
        public int id { get; set; }
        public string status { get; set; }
        public DateTime last_sign_in_at { get; set; }
        public User user { get; set; }
        public Role role { get; set; }
    }
}
