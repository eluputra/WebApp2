using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class PricingPuppyModel
    {
        [Key]
        public int pricePuppyID { get; set; }

        public string PricePuppyDesc { get; set; }

        public double pricePuppy { get; set; }

        public string pricePuppyImageUrl { get; set; }

    }
}