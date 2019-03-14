﻿// <auto-generated />
using System;
using BiesPro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BiesPro.Data.Migrations
{
    [DbContext(typeof(BiesProContext))]
    partial class BiesProContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiesPro.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressText")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<int>("TownId");

                    b.HasKey("AddressId");

                    b.HasIndex("TownId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BiesPro.Models.ClientOrVendor", b =>
                {
                    b.Property<int>("ClientOrVendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("BULSTAT")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(true);

                    b.HasKey("ClientOrVendorId");

                    b.HasIndex("AddressId");

                    b.ToTable("ClientOrVendors");
                });

            modelBuilder.Entity("BiesPro.Models.Municipality", b =>
                {
                    b.Property<int>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("MunicipalityId");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("BiesPro.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<int>("ClientId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("OrderDetailId");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int>("VendorId");

                    b.HasKey("OrderId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ClientId");

                    b.HasIndex("OrderDetailId")
                        .IsUnique();

                    b.HasIndex("VendorId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BiesPro.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(true);

                    b.HasKey("OrderDetailId");

                    b.ToTable("OrdersDetails");
                });

            modelBuilder.Entity("BiesPro.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientOrVendorId");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("PersonId");

                    b.HasIndex("ClientOrVendorId")
                        .IsUnique();

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BiesPro.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MunicipalityId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("TownId");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("BiesPro.Models.Address", b =>
                {
                    b.HasOne("BiesPro.Models.Town", "Town")
                        .WithMany("Addresses")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiesPro.Models.ClientOrVendor", b =>
                {
                    b.HasOne("BiesPro.Models.Address", "Address")
                        .WithMany("ClientOrVendors")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiesPro.Models.Order", b =>
                {
                    b.HasOne("BiesPro.Models.Address", "DeliveryAddress")
                        .WithOne("Order")
                        .HasForeignKey("BiesPro.Models.Order", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiesPro.Models.ClientOrVendor", "Client")
                        .WithMany("OrderClient")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiesPro.Models.OrderDetail", "OrderDetails")
                        .WithOne("Order")
                        .HasForeignKey("BiesPro.Models.Order", "OrderDetailId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiesPro.Models.ClientOrVendor", "Vendor")
                        .WithMany("OrderVendor")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiesPro.Models.Person", b =>
                {
                    b.HasOne("BiesPro.Models.ClientOrVendor", "ClientOrVendor")
                        .WithOne("ContactPerson")
                        .HasForeignKey("BiesPro.Models.Person", "ClientOrVendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiesPro.Models.Town", b =>
                {
                    b.HasOne("BiesPro.Models.Municipality", "Municipality")
                        .WithMany("Towns")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
