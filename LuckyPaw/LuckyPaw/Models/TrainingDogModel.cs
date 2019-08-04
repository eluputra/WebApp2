using System;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class TrainingDogModel
    {
        [Key]
        public int TrainingId { get; set; }

        public int DogId { get; set; }

        public string TrainerName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Graduation Date")]
        public DateTime GraduationDate { get; set; }

        public string TrainingType { get; set; }

    }
}