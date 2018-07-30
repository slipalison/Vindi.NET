using System;
using System.Collections.Generic;
using System.Text;

namespace Vindi.NET.Model
{
    class Test
    {
    }

    public class Rootobject
    {
        public Subscription[] subscriptions { get; set; }
        public Plan[] plans { get; set; }
        public Product[] products { get; set; }
        public Payment_Methods[] payment_methods { get; set; }
        public Period[] periods { get; set; }

        public Bill[] bills { get; set; }

        public Charge[] charges { get; set; }
        public Invoice[] invoices { get; set; }
        public Message[] messages { get; set; }
        public Import_Batche[] import_batches { get; set; }
        public Issue[] issues { get; set; }
        public Notification[] notifications { get; set; }
        public Merchant[] merchants { get; set; }
        public Merchant_Users[] merchant_users { get; set; }

        public Role[] roles { get; set; }

    }












}
