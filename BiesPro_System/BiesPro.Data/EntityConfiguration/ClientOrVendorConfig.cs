namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ClientOrVendorConfig : IEntityTypeConfiguration<ClientOrVendor>
    {
        public void Configure(EntityTypeBuilder<ClientOrVendor> builder)
        {
            builder.HasKey(cv => cv.Id);

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
                .HasForeignKey(cv => cv.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cv => cv.ContactPerson)
                .WithOne(p => p.ClientOrVendor)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}