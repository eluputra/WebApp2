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
            if (context.PricingModel.Any())
            {
                return;   // DB has been seeded
            }
            
            var prices = new PricingModel[]
            {
                new PricingModel { PriceDesc = "Test1",   price = 100,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test2",   price = 200,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test3",   price = 300,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test4",   price = 400,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test5",   price = 500,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test6",   price = 600,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test7",   price = 700,
                    image_url = "https:\\www.google.com" },
                new PricingModel { PriceDesc = "Test8",   price = 800,
                    image_url = "https:\\www.google.com" }
            };

            foreach (PricingModel pModel in prices)
            {
                context.PricingModel.Add(pModel);
            }

            context.SaveChanges();

            var training = new TrainingDogModel[]
            {
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Evan", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Anthony", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "John", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "William", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Romeo", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Robert", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Lynda", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" },
                new TrainingDogModel { TrainingId = 111,   DogId = 100,
                    TrainerName = "Jesus", GraduationDate = DateTime.Parse("1995-03-11"),
                    TrainingType = "Manual" }
            };

            foreach (TrainingDogModel trainingDog in training)
            {
                context.TrainingDogModel.Add(trainingDog);
            }

            context.SaveChanges();
        }
    }
}

