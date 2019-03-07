using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiesPro.Data.EntityConfiguration

{
    using BiesPro.Models;
    using Microsoft.EntityFrameworkCore;

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
                .HasForeignKey(a => a.TownId);
        }
    }
}