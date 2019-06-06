﻿namespace BiesPro.Data
{
    using Models;
    using EntityConfiguration;
    using Microsoft.EntityFrameworkCore;


    public class BiesProContext : DbContext
    {
        public BiesProContext()
        {
        }

        public BiesProContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<ClientOrVendor> ClientOrVendors { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO move file in a appsettings.json file
            if (optionsBuilder.IsConfigured == false)
            {
                // throw new NotImplementedException("Connection string is not set!!");
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-CVEQJBP\SQLEXPRESS;Database=BiesProDB;Trusted_Connection=True;");
                //here will be used the PostdGreSQL service provider
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration();
            //TODO model properties should be created in separate classes in EntityConfiguration directory and for every class => new instance of the class in method modelBuilder.ApplyConfiguration();

            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new ClientOrVendorConfig());
            modelBuilder.ApplyConfiguration(new MunicipalityConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderDetailConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new TownConfig());
        }
    }
}