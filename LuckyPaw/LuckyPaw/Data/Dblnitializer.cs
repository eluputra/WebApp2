using LuckyPaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyPaw.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LuckyPawContext context)
        {
            context.Database.EnsureCreated();

            // Look for any prices.
            if (context.PricingPuppyModel.Any())
            {
                return;   // DB has been seeded
            }
            
            var pricesPuppyArr = new PricingPuppyModel[]
            {
                new PricingPuppyModel { PricePuppyDesc = "Test1",   pricePuppy = 100,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test2",   pricePuppy = 200,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test3",   pricePuppy = 300,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test4",   pricePuppy = 400,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test5",   pricePuppy = 500,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test6",   pricePuppy = 600,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test7",   pricePuppy = 700,
                    pricePuppyImageUrl = "https:\\www.google.com" },
                new PricingPuppyModel { PricePuppyDesc = "Test8",   pricePuppy = 800,
                    pricePuppyImageUrl = "https:\\www.google.com" }
            };

            foreach (PricingPuppyModel pPuppyModel in pricesPuppyArr)
            {
                context.PricingPuppyModel.Add(pPuppyModel);
            }

            context.SaveChanges();
            
            // TrainingId cannot be the same because trainingId is the key, so
            // if you make trainingId the same, there would be a database seed error
            // For the TrainingId, you cannot set values for this column because it is a primary key, it auto increments
            var trainingArr = new TrainingDogModel[]
            {
                new TrainingDogModel { DogId = "Mark",
                    TrainerName = "Evan", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Andy",
                    TrainerName = "Anthony", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "William",
                    TrainerName = "John", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Michael",
                    TrainerName = "William", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Ronnie",
                    TrainerName = "Romeo", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Getrude",
                    TrainerName = "Robert", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Sen",
                    TrainerName = "Lynda", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogId = "Ten",
                    TrainerName = "Jesus", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" }
            };

            foreach (TrainingDogModel trainingDog in trainingArr)
            {
                context.TrainingDogModel.Add(trainingDog);
            }

            context.SaveChanges();

            var trainingServicesPriceArr = new TrainingServicesPriceModel[]
            {
                new TrainingServicesPriceModel { trainingName = "Train1",
                    priceTraining = 3000, trainingDesc = "Train1Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train2",
                    priceTraining = 4000, trainingDesc = "Train2Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train3",
                    priceTraining = 5000, trainingDesc = "Train3Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train4",
                    priceTraining = 6000, trainingDesc = "Train4Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train5",
                    priceTraining = 7000, trainingDesc = "Train5Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train6",
                    priceTraining = 8000, trainingDesc = "Train6Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train7",
                    priceTraining = 9000, trainingDesc = "Train7Desc"
                    },
                new TrainingServicesPriceModel { trainingName = "Train8",
                    priceTraining = 10000, trainingDesc = "Train8Desc"
                    }
            };

            foreach (TrainingServicesPriceModel trainingServicesPrice in trainingServicesPriceArr)
            {
                context.TrainingServicesPriceModel.Add(trainingServicesPrice);
            }

            context.SaveChanges();
        }
    }
}

