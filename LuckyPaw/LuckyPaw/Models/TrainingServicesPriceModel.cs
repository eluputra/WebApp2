using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class TrainingServicesPriceModel
    {
        [Key]
        public int trainingServicesPriceID { get; set; }

        public string trainingName { get; set; }

        public double priceTraining { get; set; }

        public string trainingDesc { get; set; }

    }
}