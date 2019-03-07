using BiesPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiesPro.Data.EntityConfiguration
{
    public class ClientOrVendorConfig : IEntityTypeConfiguration<ClientOrVendor>
    {
        public void Configure(EntityTypeBuilder<ClientOrVendor> builder)
        {
            builder.HasKey(cv => cv.ClientOrVendorId);

            builder.Property(cv => cv.Name)
                .HasMaxLength(40)
                .IsRequired()
                .IsUnicode();

            builder.Property(cv => cv.BULSTAT)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode(false);

            builder.HasOne(cv => cv.Address)
                .WithMany(a => a.ClientOrVendors)
                .HasForeignKey(cv => cv.AddressId);

            builder.HasOne(cv => cv.DeliveryAddress)
                .WithMany(a => a.ClientOrVendors)
                .HasForeignKey(cv => cv.DeliveryAddressId);

            builder.HasOne(cv => cv.ContactPerson)
                .WithOne(p => p.ClientOrVendor);
        }
    }
}