using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryTracking.Models
{
    public class Item
    {
        public long Id { get; set; }

        public string ItemCode { get; set; }

        public string Description { get; set; }

        public decimal  rate{get;set;}
    }
}
