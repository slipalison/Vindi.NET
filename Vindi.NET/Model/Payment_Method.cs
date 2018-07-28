using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    public class Payment_Method
    {
        public int id { get; set; }
        public string public_name { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string type { get; set; }
    }

}
