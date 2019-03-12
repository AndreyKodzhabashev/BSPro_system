namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.AddressId);

            builder.Property(a => a.AddressText)
                .HasMaxLength(250)
                .IsRequired()
                .IsUnicode();

            builder.HasOne(a => a.Town)
                .WithMany(t => t.Addresses)
                .HasForeignKey(a => a.TownId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}//Cannot create a relationship between 'Address.ClientOrVendors' and 'ClientOrVendor.DeliveryAddress', because there already is a relationship between 'Address.ClientOrVendors' and 'ClientOrVendor.Address'. Navigation properties can only participate in a single relationship.