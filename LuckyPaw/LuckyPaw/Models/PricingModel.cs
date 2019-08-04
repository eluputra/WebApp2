using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class PricingModel
    {
        [Key]
        public int priceID { get; set; }

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string PriceDesc { get; set; }

        public double price { get; set; }

        public string image_url { get; set; }
    }
}