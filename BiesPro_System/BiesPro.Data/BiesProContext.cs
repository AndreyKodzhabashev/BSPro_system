using System;
using Microsoft.EntityFrameworkCore;

namespace BiesPro.Data
{
    public class BiesProContext : DbContext
    {
        public BiesProContext()
        {
        }

        public BiesProContext(DbContextOptions options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO move file in a appsettings.json file
            if (optionsBuilder.IsConfigured == false)
            {
                throw new NotImplementedException("Connection string is not set!!");
                optionsBuilder.UseSqlServer("Connection string");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration();
            //TODO model properties should be created in separate classes in EntityConfiguration directory and for every class => new instance of the class in method modelBuilder.ApplyConfiguration();
        }
    }
}