using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeliveryTracking.Models
{
    public class Order
    {
        public long ID { get; set; }
        //public string _key;

        //public string key
        //{
        //    get
        //    {
        //        if(_key== null)
        //        {
        //            _key=Regex.Replace(OrderCode.ToLower(),)
        //        }
        //    }
        //}

        [Display(Name="Order Code")]
        [Required]
        public string OrderCode { get; set; }

        public DateTime OrderDateTime { get; set; }

        public int OrderStatus { get; set; }

        public string comments { get; set; }

        public ICollection<OrderDetails> OrderDtl { get; set; }
    }
}
