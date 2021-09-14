﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryTracking.Models
{
    public class OrderDetails
    {
        public long Id { get; set; }

        public long OrderId { get; set; }

        public long ItemId { get; set; }

        public int Quantity { get; set; }

        public decimal Totalrate { get; set; }
    }
}
