using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckyPaw.Models;
using Microsoft.EntityFrameworkCore;

namespace LuckyPaw.Data
{
    public class LuckyPawContext : DbContext
    {

        public DbSet<LuckyPaw.Models.PricingModel> PricingModel { get; set; }

        public DbSet<LuckyPaw.Models.TrainingDogModel> TrainingDogModel { get; set; }

        public LuckyPawContext(DbContextOptions<LuckyPawContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // this code for building the model 
        {
            modelBuilder.Entity<PricingModel>().ToTable("Price");
            modelBuilder.Entity<TrainingDogModel>().ToTable("Training");
        }

    }
}
