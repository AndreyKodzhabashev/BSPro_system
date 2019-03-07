﻿using BiesPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiesPro.Data.EntityConfiguration
{
    public class PersonConfig : IEntityTypeConfiguration<Person>

    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.PersonId);

            builder.Property(p => p.FirstName)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.LastName)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.EGN)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode(false);

            builder.HasOne(p => p.Address)
                .WithMany(a => a.Persons)
                .HasForeignKey(p => p.AddressId);

            builder.HasOne(p => p.ClientOrVendor)
                .WithOne(cv => cv.ContactPerson);
        }
    }
}